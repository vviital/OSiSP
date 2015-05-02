namespace Lab2
{
    using System;

    /// <summary>
    /// Class which represent smart watch.
    /// </summary>
    [Alias(AlternativeName = "SWatch")]
    public class SmartWatch : ICalculate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmartWatch"/> class by using pseudorandom number generator.
        /// </summary>
        public SmartWatch()
        {
            Random random = new Random();
            this.CurrentH = random.Next() % 24;
            this.CurrentM = random.Next() % 60;
            this.CurrentS = random.Next() % 60;
            this.ReminderH = random.Next() % 24;
            this.ReminderM = random.Next() % 60;
            this.ReminderS = random.Next() % 60;
        }

        /// <summary>
        /// Gets or sets the current hour.
        /// </summary>
        /// <value>
        /// The current hour.
        /// </value>
        public int CurrentH { get; set; }

        /// <summary>
        /// Gets or sets the current minute.
        /// </summary>
        /// <value>
        /// The current minute.
        /// </value>
        public int CurrentM { get; set; }

        /// <summary>
        /// Gets or sets the current second.
        /// </summary>
        /// <value>
        /// The current second.
        /// </value>
        public int CurrentS { get; set; }

        /// <summary>
        /// Gets or sets the reminder hour.
        /// </summary>
        /// <value>
        /// The reminder hour.
        /// </value>
        public int ReminderH { get; set; }

        /// <summary>
        /// Gets or sets the reminder minute.
        /// </summary>
        /// <value>
        /// The reminder minute.
        /// </value>
        public int ReminderM { get; set; }

        /// <summary>
        /// Gets or sets the reminder second.
        /// </summary>
        /// <value>
        /// The reminder second.
        /// </value>
        public int ReminderS { get; set; }

        /// <summary>
        /// Calculates how much time is left until the reminder.
        /// </summary>
        /// <returns>
        /// Integer value
        /// </returns>
        public int Calculate()
        {
            int value1 = (this.CurrentH * 3600) + (this.CurrentM * 60) + this.CurrentS;
            int value2 = (this.ReminderH * 3600) + (this.ReminderM * 60) + this.ReminderS;
            int result = value2 - value1;
            if (result < 0)
            {
                result = (24 * 3600) - value1 + value1;
            }

            return result;
        }
    }
}
