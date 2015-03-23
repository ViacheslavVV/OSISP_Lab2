// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AbstractRedColor.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the AbstractRedColor type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OSISP_Lab2
{
    /// <summary>
    /// The abstract red color.
    /// </summary>
    [AlternativeName(Name = "ARedColor")]
    public abstract class AbstractRedColor
    {
        /// <summary>
        /// Gets or sets the r.
        /// </summary>
        public byte R { get; set; }

        /// <summary>
        /// Gets or sets the g.
        /// </summary>
        public byte G { get; set; }

        /// <summary>
        /// Gets or sets the b.
        /// </summary>
        public byte B { get; set; }
    }
}
