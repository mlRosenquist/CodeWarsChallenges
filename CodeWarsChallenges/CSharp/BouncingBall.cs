using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.BouncingBall
{
    public class BouncingBall
    {
        public static int bouncingBall(double h, double bounce, double window)
        {
            if (AreConditionsNotMet(h, bounce, window))
                return -1;

            return RecBouncingBalls(h, bounce, window, 1);
        }

        private static int RecBouncingBalls(double h, double bounce, double window, int timesAboveWindow)
        {
            var bounceHeigh = h * bounce;

            if (bounceHeigh > window)
                return RecBouncingBalls(bounceHeigh, bounce, window, timesAboveWindow + 2);

            return timesAboveWindow;
        }
        private static bool AreConditionsNotMet(double h, double bounce, double window)
        {
            return h <= 0 || (bounce <= 0 || bounce >= 1) || window >= h;
        }
    }
}
