using System.Threading;
using System.Threading.Tasks;
using ModelContextProtocol.Client;

namespace TgLlmBot.Services.Mcp.Clients.Github;

public interface IGithubMcpClientFactory
{
    Task<McpClient> CreateAsync(CancellationToken cancellationToken);
}
