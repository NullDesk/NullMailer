﻿using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace NullDesk.Extensions.Mailer.Core
{
    /// <summary>
    /// Class StringExtensions.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Replaces content in a string for each of the values in a replacement variables dictionary 
        /// </summary>
        /// <param name="content">The template content</param>
        /// <param name="replacementVariables">The replacement variables</param>
        /// <returns></returns>
        public static string TemplateReplace(this string content, IDictionary<string, string> replacementVariables){
            var result = new StringBuilder(content);
            foreach (var item in replacementVariables)
            {
                result.Replace(item.Key, item.Value);
            }
            return result.ToString();
        }
    }
}