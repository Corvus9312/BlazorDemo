using Microsoft.AspNetCore.Components;
using static BlazorDemo.Pages.BlogPostFooter;

namespace BlazorDemo.Pages;

public class BlogPostBase : ComponentBase
{
    [Parameter]
    public int Id { get; set; }

    public FooterModel? Previous { get; set; }

    public FooterModel? Next { get; set; }

    public string Content { get; set; } = null!;

    public List<string> Comments { get; set; } = new();

    protected override void OnParametersSet()
    {
        if (Id.Equals(1))
        {
            Previous = null;
            Next = new FooterModel { Title = "簡介", Url = "blog/2" };
        }
        else if (Id.Equals(2))
        {
            Previous = new FooterModel { Title = "前言", Url = "blog/1" };
            Next = null;
        }

        Content = Id switch
        {
            1 => "前言",
            2 => "簡介",
            _ => string.Empty
        };

        Comments = new();

        base.OnParametersSet();
    }

    protected void ButtonOnClick(List<string> comments)
    {
        Comments = comments;

        StateHasChanged();
    }
}