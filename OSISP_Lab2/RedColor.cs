// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RedColor.cs" company="">
//   
// </copyright>
// <summary>
//   The red color.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OSISP_Lab2
{
    /// <summary>
    /// The red color.
    /// </summary>
    [AlternativeName(Name = "Red")]
    public class RedColor : AbstractRedColor
    {
        /// <summary>
        /// Gets or sets a value indicating whether only r.
        /// </summary>
        public bool OnlyR { get; set; }
    }
}
