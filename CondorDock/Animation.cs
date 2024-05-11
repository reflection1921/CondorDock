using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media;

namespace CondorDock
{
    internal class Animation
    {
        /// <summary>
        /// Run a bounce animation on a control
        /// </summary>
        /// <param name="control">The control to animate</param>
        /// <param name="from">Relative start position of the control animation</param>
        /// <param name="to">Relative end position of the control animation</param>
        /// <param name="duration">Duration of the animation in seconds</param>
        public static void RunBounceAnimation(Control control, double from, double to, double duration)
        {
            DoubleAnimation dblAni = new(from, to, TimeSpan.FromSeconds(duration))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            TranslateTransform trans = new();
            control.RenderTransform = trans;

            trans.BeginAnimation(TranslateTransform.YProperty, dblAni);
        }
    }
}
