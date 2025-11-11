using System;
using TgLlmBot.Configuration.Options;
using TgLlmBot.Configuration.TypedConfiguration.DataAccess;
using TgLlmBot.Configuration.TypedConfiguration.Llm;
using TgLlmBot.Configuration.TypedConfiguration.Mcp;
using TgLlmBot.Configuration.TypedConfiguration.Telegram;

namespace TgLlmBot.Configuration.TypedConfiguration;

public class ApplicationConfiguration
{
    private ApplicationConfiguration(
        TelegramConfiguration telegram,
        LlmConfiguration llm,
        DataAccessConfiguration dataAccess,
        McpConfiguration mcp)
    {
        ArgumentNullException.ThrowIfNull(telegram);
        ArgumentNullException.ThrowIfNull(llm);
        ArgumentNullException.ThrowIfNull(dataAccess);
        ArgumentNullException.ThrowIfNull(mcp);
        Telegram = telegram;
        Llm = llm;
        DataAccess = dataAccess;
        Mcp = mcp;
    }

    public TelegramConfiguration Telegram { get; }
    public LlmConfiguration Llm { get; }
    public DataAccessConfiguration DataAccess { get; }
    public McpConfiguration Mcp { get; }

    public static ApplicationConfiguration Convert(ApplicationOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);
        var telegram = TelegramConfiguration.Convert(options.Telegram);
        var llm = LlmConfiguration.Convert(options.Llm);
        var dataAccess = DataAccessConfiguration.Convert(options.DataAccess);
        var mcp = McpConfiguration.Convert(options.Mcp);
        return new(
            telegram,
            llm,
            dataAccess,
            mcp);
    }
}
