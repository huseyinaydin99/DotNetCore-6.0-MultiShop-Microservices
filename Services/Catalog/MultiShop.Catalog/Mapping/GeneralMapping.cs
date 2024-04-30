using AutoMapper;
using MultiShop.Catalog.DTOs.CategoryDTOs;
using MultiShop.Catalog.DTOs.FeatureSliderDTOs;
using MultiShop.Catalog.DTOs.ProductDetailDTOs;
using MultiShop.Catalog.DTOs.ProductDTOs;
using MultiShop.Catalog.DTOs.ProductImageDTOs;
using MultiShop.Catalog.DTOs.SpecialOfferDTOs;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Mapping;

public class GeneralMapping : Profile
{
    public GeneralMapping()
    {
        CreateMap<Category, ResultCategoryDTO>().ReverseMap();
        CreateMap<Category, CreateCategoryDTO>().ReverseMap();
        CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
        CreateMap<Category, GetByIdCategoryDTO>().ReverseMap();

        CreateMap<Product, ResultProductDTO>().ReverseMap();
        CreateMap<Product, CreateProductDTO>().ReverseMap();
        CreateMap<Product, UpdateProductDTO>().ReverseMap();
        CreateMap<Product, GetByIdProductDTO>().ReverseMap();

        CreateMap<ProductDetail, ResultProductDetailDTO>().ReverseMap();
        CreateMap<ProductDetail, CreateProductDetailDTO>().ReverseMap();
        CreateMap<ProductDetail, UpdateProductDetailDTO>().ReverseMap();
        CreateMap<ProductDetail, GetByIdProductDetailDTO>().ReverseMap();

        CreateMap<ProductImage, ResultProductImageDTO>().ReverseMap();
        CreateMap<ProductImage, CreateProductImageDTO>().ReverseMap();
        CreateMap<ProductImage, UpdateProductImageDTO>().ReverseMap();
        CreateMap<ProductImage, GetByIdProductImageDTO>().ReverseMap();

        CreateMap<Product, ResultProductsWithCategoryDTO>().ReverseMap();

        CreateMap<FeatureSlider, ResultFeatureSliderDTO>().ReverseMap();
        CreateMap<FeatureSlider, CreateFeatureSliderDTO>().ReverseMap();
        CreateMap<FeatureSlider, UpdateFeatureSliderDTO>().ReverseMap();
        CreateMap<FeatureSlider, GetByIdFeatureSliderDTO>().ReverseMap();

        CreateMap<SpecialOffer, ResultSpecialOfferDTO>().ReverseMap();
        CreateMap<SpecialOffer, CreateSpecialOfferDTO>().ReverseMap();
        CreateMap<SpecialOffer, UpdateSpecialOfferDTO>().ReverseMap();
        CreateMap<SpecialOffer, GetByIdSpecialOfferDTO>().ReverseMap();
    }
}