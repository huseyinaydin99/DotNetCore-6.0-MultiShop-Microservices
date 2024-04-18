using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.DTOs.ProductDetailDTOs;
using MultiShop.Catalog.Entities;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.ProductDetailDetailServices;

public class ProductDetailService : IProductDetailService
{
    private readonly IMapper _mapper;
    private readonly IMongoCollection<ProductDetail> _productDetailCollection;

    public ProductDetailService(IMapper mapper, IDatabaseSettings _databaseSettings)
    {
        var client = new MongoClient(_databaseSettings.ConnectionString);
        var database = client.GetDatabase(_databaseSettings.DatabaseName);
        _productDetailCollection = database.GetCollection<ProductDetail>(_databaseSettings.ProductDetailCollectionName);
        _mapper = mapper;
    }

    public async Task CreateProductDetailAsync(CreateProductDetailDTO createProductDetailDTO)
    {
        var values = _mapper.Map<ProductDetail>(createProductDetailDTO);
        await _productDetailCollection.InsertOneAsync(values);
    }
    public async Task DeleteProductDetailAsync(string id)
    {
        await _productDetailCollection.DeleteOneAsync(x => x.ProductDetailId == id);
    }

    public async Task<GetByIdProductDetailDTO> GetByIdProductDetailAsync(string id)
    {
        var values = await _productDetailCollection.Find<ProductDetail>(x => x.ProductDetailId == id).FirstOrDefaultAsync();
        return _mapper.Map<GetByIdProductDetailDTO>(values);
    }

    public async Task<GetByIdProductDetailDTO> GetByProductIdProductDetailAsync(string id)
    {
        var values = await _productDetailCollection.Find<ProductDetail>(x => x.ProductId == id).FirstOrDefaultAsync();
        return _mapper.Map<GetByIdProductDetailDTO>(values);
    }

    public async Task<List<ResultProductDetailDTO>> GettAllProductDetailAsync()
    {
        var values = await _productDetailCollection.Find(x => true).ToListAsync();
        return _mapper.Map<List<ResultProductDetailDTO>>(values);
    }
    public async Task UpdateProductDetailAsync(UpdateProductDetailDTO updateProductDetailDTO)
    {
        var values = _mapper.Map<ProductDetail>(updateProductDetailDTO);
        await _productDetailCollection.FindOneAndReplaceAsync(x => x.ProductDetailId == updateProductDetailDTO.ProductDetailId, values);
    }
}