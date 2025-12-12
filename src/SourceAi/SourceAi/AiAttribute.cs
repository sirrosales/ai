using System;

namespace SourceAi;

[AttributeUsage(AttributeTargets.Method)]
public class AiAttribute : Attribute
{
    public string Prompt { get; }
    public AiAttribute(string prompt = "") => Prompt = prompt;
}