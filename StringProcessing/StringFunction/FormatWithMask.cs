﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FormatWithMask.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Zeroit.Framework.Utilities.StringProcessing
{
    /// <summary>
    /// Class StringFunctions.
    /// </summary>
    public static partial class StringFunctions
    {

        //---------------------------------Implementation-----------------------------//

        //var s = "aaaaaaaabbbbccccddddeeeeeeeeeeee".FormatWithMask("Hello ########-#A###-####-####-############ Oww");
        //s.ShouldEqual("Hello aaaaaaaa-bAbbb-cccc-dddd-eeeeeeeeeeee Oww");

        //var s = "abc".FormatWithMask("###-#");
        //s.ShouldEqual("abc-");

        //var s = "".FormatWithMask("Hello ########-#A###-####-####-############ Oww");
        //s.ShouldEqual("");
        //---------------------------------Implementation-----------------------------//


        /// <summary>
        /// Formats the string according to the specified mask
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="mask">The mask for formatting. Like "A##-##-T-###Z"</param>
        /// <returns>The formatted string</returns>
        public static string FormatWithMask(this string input, string mask)
        {
            
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            var output = string.Empty;
            var index = 0;
            foreach (var m in mask)
            {
                if (m == '#')
                {
                    if (index < input.Length)
                    {
                        output += input[index];
                        index++;
                    }
                }
                else
                    output += m;
            }
            return output;
        }

        
    }
}
