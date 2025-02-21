using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers;

public class ProductUrlResolver(IConfiguration config)
    : IValueResolver<Product, ProductToReturnDto, string>
{
    private readonly IConfiguration _config = config;

    public string Resolve(
        Product source,
        ProductToReturnDto destination,
        string destMember,
        ResolutionContext context
    )
    {
        if (!string.IsNullOrEmpty(source.PictureUrl))
        {
            return _config["ApiUrl"] + source.PictureUrl;
        }
        return null;
    }
}
