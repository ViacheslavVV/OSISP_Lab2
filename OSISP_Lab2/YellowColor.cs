// --------------------------------------------------------------------------------------------------------------------
// <copyright file="YellowColor.cs" company="">
//   
// </copyright>
// <summary>
//   The yellow color.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OSISP_Lab2
{
    /// <summary>
    /// The yellow color.
    /// </summary>
    [AlternativeName(Name = "Yellow")]
    public class YellowColor : IYellowColor
    {
        /// <summary>
        /// The get full color.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetFullColor()
        {
            return "Yellow";
        }
    }
}
