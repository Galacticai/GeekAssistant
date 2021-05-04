
//using Transitions;
using System.Windows.Forms;
using FluentTransitions;
internal static partial class Animate {
    /// <summary>
    /// Animate a property of an object with critical damping
    /// </summary>
    /// <param name="target">Parent object to work with</param>
    /// <param name="propName">Property of object to animate</param>
    /// <param name="destination">Final value of prop</param>
    /// <param name="AnimationTime">Optional animation time (ms) (Default: 500ms)</param>
    public static void Run(Control target, string propName, object destination, int AnimationTime = 500) {
        if (c.S.PerformAnimations)
            Transition.With(target, propName, destination).CriticalDamp(new System.TimeSpan(0, 0, 0, 0, AnimationTime));
        //Transition.run(target, propName, destination, new TransitionType_CriticalDamping(AnimationTime));
        else {
            var propInfo = target.GetType().GetProperty(propName);
            propInfo.SetValue(target, destination);
        }
    }
}