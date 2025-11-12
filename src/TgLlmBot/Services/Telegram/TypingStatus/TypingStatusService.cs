namespace TgLlmBot.Services.Telegram.TypingStatus;

using System.Threading.Channels;

public class TypingStatusService : ITypingStatusService
{
    private readonly ChannelWriter<TypingCommand> _commandWriter;

    public TypingStatusService(ChannelWriter<TypingCommand> commandWriter)
    {
        _commandWriter = commandWriter;
    }

    // ReSharper disable once PreferConcreteValueOverDefault
    public void SetTypingStatus(long chatId, int? threadId = default)
    {
        _commandWriter.TryWrite(new StartTypingCommand(chatId, threadId));
    }

    // ReSharper disable once PreferConcreteValueOverDefault
    public void RemoveTypingStatus(long chatId, int? threadId = default)
    {
        _commandWriter.TryWrite(new StopTypingCommand(chatId, threadId));
    }
}
