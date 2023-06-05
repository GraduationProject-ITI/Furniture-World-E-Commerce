﻿using AutoMapper;
using Core;

namespace API;

public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
{
    private readonly IConfiguration configuration;

    public ProductUrlResolver(IConfiguration configuration)
    {
        this.configuration = configuration;
    }
    public string Resolve(Product source, ProductToReturnDto destination, string destMember, ResolutionContext context)
    {
        if(!string.IsNullOrEmpty(source.imgUrl))
        {
            return configuration["ApiUrl"] + source.imgUrl;
        }
        return null;
    }
}
