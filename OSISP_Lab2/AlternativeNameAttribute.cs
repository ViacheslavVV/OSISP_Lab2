// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AlternativeNameAttribute.cs" company="">
//   
// </copyright>
// <summary>
//   The alternative name attribute.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OSISP_Lab2
{
    using System;

    /// <summary>
    /// The alternative name attribute.
    /// </summary>
    [AlternativeName(Name = "Alternative")]
    public class AlternativeNameAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }
        
    }
}
