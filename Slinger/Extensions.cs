//-----------------------------------------------------------------------
// <copyright file = "Extensions.cs" company = "Me!">
//     Copyright (c) Me!  All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Slinger.Source
{
    public static class Extensions
    {
        /// <summary>
        /// Reverses the order of every four bytes of the byte array
        /// </summary>
        /// <param name="byteArray"></param>
        public static void FixBytes(this byte[] byteArray)
        {
            var temp = new byte[4];

            for(var index = 0; index < byteArray.Length; index += 4)
            {
                for(var tempIndex = 0; tempIndex < 4; tempIndex++)
                {
                    temp[tempIndex] = byteArray[index + tempIndex];
                }

                for(var tempIndex = 0; tempIndex < 4; tempIndex++)
                {
                    byteArray[index + (3 - tempIndex)] = temp[tempIndex];
                }
            }
        }
    }
}
