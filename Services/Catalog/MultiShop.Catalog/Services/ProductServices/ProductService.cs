using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.DTOs.CategoryDTOs;
using MultiShop.Catalog.DTOs.ProductDTOs;
using MultiShop.Catalog.Entities;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.ProductServices;

public class ProductService : IProductService
{
    private readonly IMapper _mapper;
    private readonly IMongoCollection<Product> _productCollection;
    private readonly IMongoCollection<Category> _categoryCollection;

    public ProductService(IMapper mapper, IDatabaseSettings _databaseSettings)
    {
        var client = new MongoClient(_databaseSettings.ConnectionString);
        var database = client.GetDatabase(_databaseSettings.DatabaseName);
        _productCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
        _categoryCollection = database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
        _mapper = mapper;
    }

    public async Task CreateProductAsync(CreateProductDTO createProductDTO)
    {
        var values = _mapper.Map<Product>(createProductDTO);
        await _productCollection.InsertOneAsync(values);
    }

    public async Task DeleteProductAsync(string id)
    {
        await _productCollection.DeleteOneAsync(x => x.ProductId == id);
    }

    public async Task<GetByIdProductDTO> GetByIdProductAsync(string id)
    {
        var values = await _productCollection.Find<Product>(x => x.ProductId == id).FirstOrDefaultAsync();
        return _mapper.Map<GetByIdProductDTO>(values);
    }

    public async Task<List<ResultProductsWithCategoryDTO>> GetProductsWithCategoryAsync()
    {
        var values = await _productCollection.Find(x => true).ToListAsync();
        foreach (var item in values)
        {
            item.Category = await _categoryCollection.Find<Category>(x => x.CategoryId == item.CategoryId).FirstAsync();
        }
        return _mapper.Map<List<ResultProductsWithCategoryDTO>>(values);
    }

    public async Task<List<ResultProductsWithCategoryDTO>> GetProductsWithCategoryByCatetegoryIdAsync(string categoryId)
    {
        var values = await _productCollection.Find(x => x.CategoryId == categoryId).ToListAsync();
        foreach (var item in values)
        {
            item.Category = await _categoryCollection.Find<Category>(x => x.CategoryId == item.CategoryId).FirstAsync();
        }
        return _mapper.Map<List<ResultProductsWithCategoryDTO>>(values);
    }

    public async Task<List<ResultProductDTO>> GetAllProductAsync()
    {
        var values = await _productCollection.Find(x => true).ToListAsync();
        return _mapper.Map<List<ResultProductDTO>>(values);
    }

    public async Task UpdateProductAsync(UpdateProductDTO updateProductDTO)
    {
        var values = _mapper.Map<Product>(updateProductDTO);
        await _productCollection.FindOneAndReplaceAsync(x => x.ProductId == updateProductDTO.ProductId, values);
    }
}