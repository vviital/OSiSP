namespace Lab2
{
    using System;

    /// <summary>
    /// Class which represent computer.
    /// </summary>
    [Alias(AlternativeName = "Comp")]
    public class Computer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Computer"/> class by using pseudorandom number generator.
        /// </summary>
        public Computer()
        {
            this.Prng = new Random();
            this.CpuFrequency = this.Prng.Next(1000, 5000);
            this.Ram = this.Prng.Next(1000, 32000);
            this.IsWork = false;
        }

        /// <summary>
        /// Gets or sets the PRNG. PRNG - pseudorandom number generator.
        /// </summary>
        /// <value>
        /// The PRNG.
        /// </value>
        public Random Prng { get; set; }

        /// <summary>
        /// Gets or sets the central processing unit frequency.
        /// </summary>
        /// <value>
        /// The central processing unit frequency.
        /// </value>
        public int CpuFrequency { get; set; }

        /// <summary>
        /// Gets or sets the ram. RAM - Random Access Memory.
        /// </summary>
        /// <value>
        /// The ram.
        /// </value>
        public int Ram { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is work.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is work; otherwise, <c>false</c>.
        /// </value>
        public bool IsWork { get; set; }

        /// <summary>
        /// Switches this instance state(on / off).
        /// </summary>
        public void Switch()
        {
            this.IsWork ^= true;
        }
    }
}
