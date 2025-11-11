using System;
using Markdig;
using TgLlmBot.Services.Telegram.Markdown.Internal.Extensions.Spoiler;

namespace TgLlmBot.Services.Telegram.Markdown.Internal;

public static class MarkdownPipelineBuilderExtensions
{
    public static MarkdownPipelineBuilder UseSpoilers(this MarkdownPipelineBuilder pipeline)
    {
        ArgumentNullException.ThrowIfNull(pipeline);
        var extensions = pipeline.Extensions;

        if (!extensions.Contains<SpoilerExtension>())
        {
            extensions.Add(new SpoilerExtension());
        }

        return pipeline;
    }
}
