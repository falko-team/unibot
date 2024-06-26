using Talkie.Interceptors;
using Talkie.Signals;

namespace Talkie.Pipelines;

public static partial class SignalPipelineBuilderExtensions
{
    public static ISignalInterceptingPipelineBuilder Skip(this ISignalInterceptingPipelineBuilder builder, int count)
    {
        return builder.Intercept(new SkipSignalInterceptor<Signal>(count));
    }

    public static ISignalInterceptingPipelineBuilder<T> Skip<T>(this ISignalInterceptingPipelineBuilder<T> builder, int count)
        where T : Signal
    {
        return builder.Intercept(new SkipSignalInterceptor<T>(count));
    }
}
