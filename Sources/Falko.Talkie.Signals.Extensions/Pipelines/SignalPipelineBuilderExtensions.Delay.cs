using Talkie.Interceptors;
using Talkie.Signals;

namespace Talkie.Pipelines;

public static partial class SignalPipelineBuilderExtensions
{
    public static ISignalInterceptingPipelineBuilder Delay(this ISignalInterceptingPipelineBuilder builder, TimeSpan delay)
    {
        return builder.Intercept(new DelaySignalInterceptor<Signal>(delay));
    }

    public static ISignalInterceptingPipelineBuilder<T> Delay<T>(this ISignalInterceptingPipelineBuilder<T> builder, TimeSpan delay)
        where T : Signal
    {
        return builder.Intercept(new DelaySignalInterceptor<T>(delay));
    }
}
