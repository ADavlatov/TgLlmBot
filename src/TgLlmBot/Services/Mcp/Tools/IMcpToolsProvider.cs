using System.Collections.Generic;
using ModelContextProtocol.Client;

namespace TgLlmBot.Services.Mcp.Tools;

public interface IMcpToolsProvider
{
    IReadOnlyCollection<McpClientTool> GetTools();
}
