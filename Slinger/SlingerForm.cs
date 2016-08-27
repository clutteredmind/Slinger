//-----------------------------------------------------------------------
// <copyright file = "SlingerForm.cs" company = "Me!">
//     Copyright (c) Me!  All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Slinger
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// The main form of the Slinger application
    /// </summary>
    public partial class SlingerForm : Form
    {
        /// <summary>
        /// A background thread in which to calculate the hashes
        /// </summary>
        private readonly BackgroundWorker hashCalculatorWorker;

        /// <summary>
        /// Default constructor
        /// </summary>
        public SlingerForm()
        {
            InitializeComponent();

            // set up hashing worker thread
            hashCalculatorWorker = new BackgroundWorker();
            hashCalculatorWorker.DoWork += HashCalculatorWorkerDoWork;
            hashCalculatorWorker.RunWorkerCompleted += HashCalculatorWorkerRunWorkerCompleted;
        }

        /// <summary>
        /// The hash calculator thread's work method
        /// </summary>
        /// <param name="sender">hashCalculatorWorker</param>
        /// <param name="doWorkEventArgs">Unused</param>
        void HashCalculatorWorkerDoWork(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            // disable the GUI
            DisableGui();
            // build a list of hashing algorithms to use and text boxes in which to display the results
            var hashAlgorithmsAndTextBoxes = new Dictionary<HashAlgorithm, TextBox>();
            if(checkBoxMd5.Checked)
            {
                hashAlgorithmsAndTextBoxes.Add(new MD5CryptoServiceProvider(), textBoxMd5);
            }
            if(checkBoxSha1.Checked)
            {
                hashAlgorithmsAndTextBoxes.Add(new SHA1CryptoServiceProvider(), textBoxSha1);
            }
            if(checkBoxSha256.Checked)
            {
                hashAlgorithmsAndTextBoxes.Add(new SHA256CryptoServiceProvider(), textBoxSha256);
            }
            if(checkBoxSha384.Checked)
            {
                hashAlgorithmsAndTextBoxes.Add(new SHA384CryptoServiceProvider(), textBoxSha384);
            }
            if(checkBoxSha512.Checked)
            {
                hashAlgorithmsAndTextBoxes.Add(new SHA512CryptoServiceProvider(), textBoxSha512);
            }
            if(checkBoxRipeMd160.Checked)
            {
                hashAlgorithmsAndTextBoxes.Add(new RIPEMD160Managed(), textBoxRipeMd160);
            }
            // calculate hashes in parallel, to hopefully save some time
            Parallel.ForEach(hashAlgorithmsAndTextBoxes, hashAlgorithmAndTextBox =>
            {
                // NOTE: no "using" statement here because the type of the stream can change, so we'll be cleaning up after ourselves manually, when each element's processing is completed
                Stream hashTargetStream;
                if(File.Exists(textBoxHashTarget.Text))
                {
                    // get hashes for a file
                    hashTargetStream = new FileStream(textBoxHashTarget.Text, FileMode.Open, FileAccess.Read, FileShare.Read);
                }
                else
                {
                    // get hashes for the string in the text box
                    hashTargetStream = new MemoryStream(Encoding.Default.GetBytes(textBoxHashTarget.Text));
                }
                // calculate a hash for the input stream
                byte[] hash = hashAlgorithmAndTextBox.Key.ComputeHash(hashTargetStream);
                // iterate through the hash's bytes and save each as a hex string
                var stringBuilder = new StringBuilder(hash.Length * 2);
                foreach(byte hashByte in hash)
                {
                    stringBuilder.AppendFormat("{0:x2}", hashByte);
                }
                // display result in the algorithm's corresponding text box
                hashAlgorithmAndTextBox.Value.BeginInvoke(
                   new MethodInvoker(() => hashAlgorithmAndTextBox.Value.Text = stringBuilder.ToString()));
                // manually clean up stream resources
                hashTargetStream.Close();
                hashTargetStream.Dispose();
            });
        }

        /// <summary>
        /// Clears GUI elements of old information
        /// </summary>
        private void ClearGui()
        {
            if(InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(ClearGui));
            }
            else
            {
                textBoxMd5.Text = "";
                textBoxSha1.Text = "";
                textBoxSha256.Text = "";
                textBoxSha384.Text = "";
                textBoxSha512.Text = "";
                textBoxRipeMd160.Text = "";
            }
        }

        /// <summary>
        /// Disables all checkboxes and buttons
        /// </summary>
        private void DisableGui()
        {
            if(InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(DisableGui));
            }
            else
            {
                foreach(Control control in Controls)
                {
                    if(control is CheckBox || control is Button)
                    {
                        control.Enabled = false;
                    }
                }
            }
        }

        /// <summary>
        /// Enables all checkboxes and buttons
        /// </summary>
        private void EnableGui()
        {
            foreach(var control in Controls)
            {
                if(control is CheckBox)
                {
                    var checkBox = control as CheckBox;
                    // make sure enable change happens on the right thread
                    checkBox.BeginInvoke(new MethodInvoker(() => checkBox.Enabled = true));
                }
                if(control is Button)
                {
                    var button = control as Button;
                    // make sure enable change happens on the right thread
                    button.BeginInvoke(new MethodInvoker(() => button.Enabled = true));
                }
            }
        }

        /// <summary>
        /// Re-enables the GUI when the hash worker is done working
        /// </summary>
        /// <param name="sender">hashCalculatorWorker</param>
        /// <param name="runWorkerCompletedEventArgs">Unused</param>
        void HashCalculatorWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs)
        {
            EnableGui();
        }

        /// <summary>
        /// Handler for Help->About
        /// </summary>
        /// <param name="sender">The menu item</param>
        /// <param name="eventArgs">Unused</param>
        private void AboutToolStripMenuItemClick(object sender, EventArgs eventArgs)
        {
            new AboutBoxForm().ShowDialog();
        }

        /// <summary>
        /// Handler for File->Exit
        /// </summary>
        /// <param name="sender">The menu item</param>
        /// <param name="eventArgs">Unused</param>
        private void ExitToolStripMenuItemClick(object sender, EventArgs eventArgs)
        {
            Close();
        }

        /// <summary>
        /// Handler for the main form's Load event
        /// </summary>
        /// <param name="sender">The main form</param>
        /// <param name="eventArgs">Unused</param>
        private void SlingerFormLoad(object sender, EventArgs eventArgs)
        {
            // if there's an additional command line argument, put that string in the text box and calculate its hashes
            if(Environment.GetCommandLineArgs().Length > 1)
            {
                textBoxHashTarget.Text = Environment.GetCommandLineArgs()[1];
                hashCalculatorWorker.RunWorkerAsync();
            }
        }

        /// <summary>
        /// Handler for the main form's DragDrop event
        /// </summary>
        /// <param name="sender">The main form</param>
        /// <param name="dragEventArgs">Data about the file(s) being dropped</param>
        private void SlingerFormDragDrop(object sender, DragEventArgs dragEventArgs)
        {
            // if the user drops more than one file, dragEventArgs will present them as an array. we can only process one file though, so we're just going to grab the first element of that array
            if(dragEventArgs.Data.GetData(DataFormats.FileDrop, false) is string[])
            {
                // put the name of the file in the hash target text box
                textBoxHashTarget.Text = ((string[])dragEventArgs.Data.GetData(DataFormats.FileDrop, false))[0];
                // clear any old hashes
                ClearGui();
                // start the calculator thread
                hashCalculatorWorker.RunWorkerAsync();
            }
        }

        /// <summary>
        /// Handler for the main form's DragEnter event
        /// </summary>
        /// <param name="sender">The main form</param>
        /// <param name="dragEventArgs">Data about the file(s) being dragged</param>
        private void SlingerFormDragEnter(object sender, DragEventArgs dragEventArgs)
        {
            dragEventArgs.Effect = dragEventArgs.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
        }

        /// <summary>
        /// Handler for the Check All button's click event
        /// </summary>
        /// <param name="sender">The Check All button</param>
        /// <param name="eventArgs">Unused</param>
        private void ButtonCheckAllClick(object sender, EventArgs eventArgs)
        {
            foreach(var control in Controls)
            {
                if(control is CheckBox)
                {
                    (control as CheckBox).Checked = true;
                }
            }
        }

        /// <summary>
        /// Handler for the Uncheck All button's click event
        /// </summary>
        /// <param name="sender">The Uncheck All button</param>
        /// <param name="eventArgs">Unused</param>
        private void ButtonUncheckAllClick(object sender, EventArgs eventArgs)
        {
            foreach(var control in Controls)
            {
                if(control is CheckBox)
                {
                    (control as CheckBox).Checked = false;
                }
            }
        }

        /// <summary>
        /// Handler for the Calculate button's click event
        /// </summary>
        /// <param name="sender">The Calculate button</param>
        /// <param name="eventArgs">Unused</param>
        private void ButtonCalculateClick(object sender, EventArgs eventArgs)
        {
            ClearGui();
            // start the calculator thread
            hashCalculatorWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Handler for the Choose File button's click event
        /// </summary>
        /// <param name="sender">The Choose File button</param>
        /// <param name="eventArgs">Unused</param>
        private void ButtonChooseFileClick(object sender, EventArgs eventArgs)
        {
            // show the file dialog so the user can select a file
            var fileDialog = new OpenFileDialog { Multiselect = false, Filter = @"All Files (*.*)|*.*" };

            if(fileDialog.ShowDialog(this) == DialogResult.OK && fileDialog.FileName != "")
            {
                // clear any old hashes
                ClearGui();
                textBoxHashTarget.Text = fileDialog.FileName;
            }
        }
    }
}
