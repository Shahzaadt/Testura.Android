﻿namespace Testura.Android.Util.Walker
{
    public class AppWalkerConfiguration
    {
        public AppWalkerConfiguration()
        {
            ShouldOnlyTapClickAbleNodes = true;
            MaxInputBeforeGoingBack = 5;
            WalkDuration = 0;
            ShouldStartActivity = true;
            ShouldGoBackToActivity = true;
        }

        /// <summary>
        /// Gets or sets a value indicating whether we should only tap nodes that have clickable set to true
        /// </summary>
        public bool ShouldOnlyTapClickAbleNodes { get; set; }

        /// <summary>
        /// Gets or sets the maximum input on the same activity page before we go back. Minus one means that we never go back.
        /// </summary>
        public int MaxInputBeforeGoingBack { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether we should start the walker by starting the activity
        /// </summary>
        public bool ShouldStartActivity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether we should go back to the selected activity if we accidently quit.
        /// </summary>
        public bool ShouldGoBackToActivity { get; set; }

        /// <summary>
        /// Gets or sets the walk duration in minutes (0 means infinity)
        /// </summary>
        public int WalkDuration { get; set; }
    }
}
