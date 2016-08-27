//-----------------------------------------------------------------------
// <copyright file = "SlingerProgram.cs" company = "Me!">
//     Copyright (c) Me!  All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Slinger
{
    using System;
    using System.Windows.Forms;

    static class SlingerProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SlingerForm());
        }
    }
}
