using System;
using System.IO;
using TgLlmBot.Configuration.Options.Mcp;

namespace TgLlmBot.Configuration.TypedConfiguration.Mcp;

public class McpGithubConfiguration
{
    private McpGithubConfiguration(string personalAccessToken, string workingDirectory, string command)
    {
        if (string.IsNullOrWhiteSpace(personalAccessToken))
        {
            throw new ArgumentException("Value cannot be null or whitespace.", nameof(personalAccessToken));
        }

        if (string.IsNullOrWhiteSpace(workingDirectory))
        {
            throw new ArgumentException("Value cannot be null or whitespace.", nameof(workingDirectory));
        }

        if (string.IsNullOrWhiteSpace(command))
        {
            throw new ArgumentException("Value cannot be null or whitespace.", nameof(command));
        }

        PersonalAccessToken = personalAccessToken;
        WorkingDirectory = workingDirectory;
        Command = command;
    }

    public string PersonalAccessToken { get; }

    public string WorkingDirectory { get; }

    public string Command { get; }

    public static McpGithubConfiguration Convert(McpGithubOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);
        var directory = new DirectoryInfo(options.WorkingDirectory);
        if (!directory.Exists)
        {
            throw new DirectoryNotFoundException($"The working directory {options.WorkingDirectory} was not found.");
        }

        return new(
            options.PersonalAccessToken,
            directory.FullName,
            options.Command);
    }
}
