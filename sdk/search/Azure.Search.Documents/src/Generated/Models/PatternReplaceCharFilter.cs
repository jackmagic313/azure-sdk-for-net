// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    /// <summary> A character filter that replaces characters in the input string. It uses a regular expression to identify character sequences to preserve and a replacement pattern to identify characters to replace. For example, given the input text &quot;aa bb aa bb&quot;, pattern &quot;(aa)\s+(bb)&quot;, and replacement &quot;$1#$2&quot;, the result would be &quot;aa#bb aa#bb&quot;. This character filter is implemented using Apache Lucene. </summary>
    public partial class PatternReplaceCharFilter : CharFilter
    {
        /// <summary> Initializes a new instance of PatternReplaceCharFilter. </summary>
        /// <param name="name"> The name of the char filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="pattern"> A regular expression pattern. </param>
        /// <param name="replacement"> The replacement text. </param>
        public PatternReplaceCharFilter(string name, string pattern, string replacement) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (pattern == null)
            {
                throw new ArgumentNullException(nameof(pattern));
            }
            if (replacement == null)
            {
                throw new ArgumentNullException(nameof(replacement));
            }

            Pattern = pattern;
            Replacement = replacement;
            ODataType = "#Microsoft.Azure.Search.PatternReplaceCharFilter";
        }

        /// <summary> Initializes a new instance of PatternReplaceCharFilter. </summary>
        /// <param name="oDataType"> The model type. </param>
        /// <param name="name"> The name of the char filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="pattern"> A regular expression pattern. </param>
        /// <param name="replacement"> The replacement text. </param>
        internal PatternReplaceCharFilter(string oDataType, string name, string pattern, string replacement) : base(oDataType, name)
        {
            Pattern = pattern;
            Replacement = replacement;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.PatternReplaceCharFilter";
        }

        /// <summary> A regular expression pattern. </summary>
        public string Pattern { get; }
        /// <summary> The replacement text. </summary>
        public string Replacement { get; }
    }
}