using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages;

public class BlogPostBase : ComponentBase
{
    [Parameter]
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    protected override void OnInitialized()
    {
        Content = Id switch
        {
            1 => "前言",
            2 => "簡介",
            _ => string.Empty
        };
    }
}