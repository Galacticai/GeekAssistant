using Transitions;

internal static partial class Animate {
    /// <summary>
    /// Animate a property of an object with critical damping
    /// </summary>
    /// <param name="target">Parent object to work with</param>
    /// <param name="prop">Property of object to animate</param>
    /// <param name="destination">Final value of prop</param>
    /// <param name="AnimationTime">Optional animation time (ms) (Default: 500ms)</param>
    public static void Run(ref object target, string prop, object destination, int AnimationTime = 500) {
        if (!S.PerformAnimations)
            AnimationTime = 1;
        Transition.run(target, prop, destination, new TransitionType_CriticalDamping(AnimationTime));
    }
}