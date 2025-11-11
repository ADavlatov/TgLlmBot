using System.Collections.Generic;
using ModelContextProtocol.Client;

namespace TgLlmBot.Services.Mcp.Tools;

public class DefaultMcpToolsProvider : IMcpToolsProvider
{
    private readonly List<McpClientTool> _tools = [];

    public IReadOnlyCollection<McpClientTool> GetTools()
    {
        return _tools;
    }

    public void AddTools(IEnumerable<McpClientTool>? tools)
    {
        if (tools is not null)
        {
            foreach (var tool in tools)
            {
                _tools.Add(tool);
            }
        }
    }
}
