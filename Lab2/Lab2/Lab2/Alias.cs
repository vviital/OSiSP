namespace Lab2
{
    using System;

    /// <summary>
    /// Attribute which used as alias for classes.
    /// </summary>
    public class Alias : Attribute
    {
        /// <summary>
        /// Gets or sets the alternative name.
        /// </summary>
        /// <value>
        /// The alternative name.
        /// </value>
        public string AlternativeName { get; set; }
    }
}
