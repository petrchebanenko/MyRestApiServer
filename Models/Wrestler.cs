
using System;

namespace MyRestApiServer.Models;

public class Wrestler
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Alias { get; set; } = string.Empty;
    public string FinishingMove { get; set; } = string.Empty;
}