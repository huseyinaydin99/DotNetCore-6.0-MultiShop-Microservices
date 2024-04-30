using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.DTOs.CategoryDTOs;
using MultiShop.Catalog.DTOs.FeatureSliderDTOs;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.FeatureSliderServices;

public class FeatureSliderService : IFeatureSliderService
{
    private readonly IMongoCollection<FeatureSlider> _featureSliderCollection;
    private readonly IMapper _mapper;

    public FeatureSliderService(IMapper mapper, IDatabaseSettings _databaseSettings)
    {
        var client = new MongoClient(_databaseSettings.ConnectionString);
        var database = client.GetDatabase(_databaseSettings.DatabaseName);
        _featureSliderCollection = database.GetCollection<FeatureSlider>(_databaseSettings.FeatureSliderCollectionName);
        _mapper = mapper;
    }

    public async Task CreateFeatureSliderAsync(CreateFeatureSliderDTO createFeatureSliderDTO)
    {
        var value = _mapper.Map<FeatureSlider>(createFeatureSliderDTO);
        await _featureSliderCollection.InsertOneAsync(value);
    }

    public async Task DeleteFeatureSliderAsync(string id)
    {
        await _featureSliderCollection.DeleteOneAsync(x => x.FeatureSliderId == id);
    }

    public Task FeatureSliderChageStatusToFalse(string id)
    {
        throw new NotImplementedException();
    }

    public Task FeatureSliderChageStatusToTrue(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ResultFeatureSliderDTO>> GetAllFeatureSliderAsync()
    {
        var values = await _featureSliderCollection.Find(x => true).ToListAsync();
        return _mapper.Map<List<ResultFeatureSliderDTO>>(values);
    }

    public async Task<GetByIdFeatureSliderDTO> GetByIdFeatureSliderAsync(string id)
    {
        var values = await _featureSliderCollection.Find<FeatureSlider>(x => x.FeatureSliderId == id).FirstOrDefaultAsync();
        return _mapper.Map<GetByIdFeatureSliderDTO>(values);
    }

    public async Task UpdateFeatureSliderAsync(UpdateFeatureSliderDTO updateFeatureSliderDTO)
    {
        var values = _mapper.Map<FeatureSlider>(updateFeatureSliderDTO);
        await _featureSliderCollection.FindOneAndReplaceAsync(x => x.FeatureSliderId == updateFeatureSliderDTO.FeatureSliderId, values);
    }
}