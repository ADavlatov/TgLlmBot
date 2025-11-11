using System.ComponentModel.DataAnnotations;

namespace TgLlmBot.Configuration.Options.Mcp;

public class McpGithubOptions
{
    [Required]
    [MaxLength(500)]
    public string PersonalAccessToken { get; set; } = default!;

    [Required]
    [MaxLength(10000)]
    public string WorkingDirectory { get; set; } = default!;

    [Required]
    [MaxLength(10000)]
    public string Command { get; set; } = default!;
}
