// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrangeColor.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the OrangeColor type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OSISP_Lab2
{
    /// <summary>
    /// The orange color.
    /// </summary>
    [AlternativeName(Name = "Orange")]
    public class OrangeColor : AbstractRedColor, IYellowColor
    {
        /// <summary>
        /// Gets or sets a value indicating whether yellow and red.
        /// </summary>
        public bool YellowAndRed { get; set; }

        /// <summary>
        /// The get full color.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetFullColor()
        {
            return "Orange";
        }
    }
}
