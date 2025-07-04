using Sitecore.AspNetCore.SDK.LayoutService.Client.Response.Model.Fields;
using Sitecore.AspNetCore.SDK.RenderingEngine.Binding.Attributes;

namespace Sitecore.AspNetCore.Starter.Models;

public class HeroComponent : BaseModel
{
    [SitecoreComponentField]
    public TextField? Title { get; set; }

    [SitecoreComponentField]
    public RichTextField? Description { get; set; }

    [SitecoreComponentField]
    public ImageField? HeroImage { get; set; }

    [SitecoreComponentField]
    public HyperLinkField? CTA { get; set; }
}
