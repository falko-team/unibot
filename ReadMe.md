# <img src="Icon64.png" width="24" hspace="5" /> Talkie

> Talkie is under active development. The underlying C# framework libraries is subject to change.

Talkie is a versatile framework designed to streamline the development of bots across various messaging platforms.

It leverages functional interfaces for messaging cross-platform compatibility,
enabling developers to write code once and deploy it on platforms like Telegram and Discord.

Whether you're building a simple chatbot or a complex bot, Talkie's lightweight design, native AOT support, and parallel processing capabilities ensure optimal performance.

## <img src="Icon64.png" width="18" hspace="5" /> Features

- **Fast and Lightweight**: Talkie is designed to be fast and lightweight, making it ideal for use in resource-constrained environments or high-traffic, large-scale bots.
- **Native-AOT Support (Latest .NET 8)**: Talkie provides native Ahead-of-Time (AOT) compilation support with the latest .NET 8 framework, enabling developers to compile bots to native code for enhanced performance and memory efficiency.
- **Parallel Processing**: Talkie is optimized to leverage multi-core processors, empowering developers to create bots capable of handling multiple messages concurrently.
- **OOP and Functional Programming**: Talkie offers flexibility by supporting both object-oriented and functional programming paradigms, allowing developers to choose the style that best aligns with their preferences and project requirements.
- **Self-Contained and Independent**: Talkie is self-contained and does not rely on external libraries. This eliminates compatibility concerns, reduces the overall footprint, and simplifies deployment.
- **Cross-Platform Compatibility**: Talkie is engineered for cross-platform compatibility, enabling developers to write code once and deploy it seamlessly across diverse bot platforms, including Telegram, Discord, and more.
- **Extensible Architecture**: Talkie is designed with extensibility in mind, making it easy for developers to add new features, functionalities, and expand platform support as needed.
- **Comprehensive Functionality**: Talkie offers a wide array of features, and managing complex branched code for different bot platforms, all while simplifying code that would be more cumbersome on other platforms.

## <img src="Icon64.png" width="18" hspace="5" /> Usage

### <img src="Icon64.png" width="14" hspace="5" /> Add the Falko Team NuGet Repository:

Open your terminal and execute the following command, replacing placeholders with your GitHub credentials:

```bash
dotnet nuget add source "https://nuget.pkg.github.com/falko-team/index.json"
    --name falko-team
    --store-password-in-clear-text
    --username $YOUR_GITHUB_USERNAME
    --password $YOUR_GITHUB_ACCESS_TOKEN
```

### <img src="Icon64.png" width="14" hspace="5" /> Install the Talkie Platforms Package:

If you're using Telegram, install the Talkie Telegram Platform package:

```bash
dotnet add package Falko.Talkie.Platforms.Telegram
```

### <img src="Icon64.png" width="14" hspace="5" /> Explore the Examples:

To get started quickly, check out the [Examples](Examples) folder in the Talkie repository
for illustrative code samples and usage demonstrations.

Simple example of code:

```C#
using Talkie.Concurrent;
using Talkie.Controllers;
using Talkie.Flows;
using Talkie.Models.Profiles;
using Talkie.Pipelines;
using Talkie.Signals;

var flow = new SignalFlow();

flow.Subscribe(signals => signals
    .OfType<IncomingMessageSignal>()
    .Where(signal => signal
        .Message
        .Content
        ?.Contains("hello", StringComparison.InvariantCultureIgnoreCase) is true)
    .HandleAsync(context => context
        .ToMessageController()
        .PublishMessageAsync("hi")
        .AsValueTask()));

await flow.ConnectTelegramAsync("YOUR_TOKEN");

await Task.Delay(-1);
```

## <img src="Icon64.png" width="18" hspace="5" /> License

This project is licensed under the [BSD 2-Clause License](License.md).

_Contributions are welcome!_

**© 2024, Falko Team**
