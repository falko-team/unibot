using Talkie.Interceptors;
using Talkie.Signals;

namespace Talkie.Pipelines;

public static partial class SignalPipelineBuilderExtensions
{
    public static ISignalInterceptingPipelineBuilder ExcludeType<T>(this ISignalInterceptingPipelineBuilder builder)
        where T : Signal
    {
        return builder.Intercept(ExcludeTypeSignalInterceptor<T>.Instance);
    }

    public static ISignalInterceptingPipelineBuilder<TOriginal> ExcludeType<TOriginal, TTyped>(this ISignalInterceptingPipelineBuilder<TOriginal> builder)
        where TOriginal : Signal
        where TTyped : TOriginal
    {
        return builder.Intercept(ExcludeTypeSignalInterceptor<TOriginal, TTyped>.Instance);
    }
}
