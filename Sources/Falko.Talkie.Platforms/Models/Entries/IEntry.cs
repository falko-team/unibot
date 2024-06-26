using Talkie.Models.Profiles;

namespace Talkie.Models.Entries;

public interface IEntry
{
    IProfile Sender { get; }

    DateTime Sent { get; }

    IProfile Receiver { get; }

    DateTime Received { get; }

    IProfile Environment { get; }
}
