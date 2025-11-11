using System;

namespace TgLlmBot.Services.Mcp.Clients.Github;

public class DefaultGithubMcpClientFactoryOptions
{
    public DefaultGithubMcpClientFactoryOptions(
        string githubPat,
        string workingDirectory,
        string command)
    {
        if (string.IsNullOrEmpty(githubPat))
        {
            throw new ArgumentException("Value cannot be null or empty.", nameof(githubPat));
        }

        if (string.IsNullOrEmpty(workingDirectory))
        {
            throw new ArgumentException("Value cannot be null or empty.", nameof(workingDirectory));
        }

        if (string.IsNullOrEmpty(command))
        {
            throw new ArgumentException("Value cannot be null or empty.", nameof(command));
        }

        GithubPat = githubPat;
        WorkingDirectory = workingDirectory;
        Command = command;
    }

    public string GithubPat { get; }
    public string WorkingDirectory { get; }
    public string Command { get; }
}
