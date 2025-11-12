namespace TgLlmBot.Services.Telegram.TypingStatus;

public interface ITypingStatusService
{
    // ReSharper disable once PreferConcreteValueOverDefault
    public void SetTypingStatus(long chatId, int? threadId = default);

    // ReSharper disable once PreferConcreteValueOverDefault
    public void RemoveTypingStatus(long chatId, int? threadId = default);
}
