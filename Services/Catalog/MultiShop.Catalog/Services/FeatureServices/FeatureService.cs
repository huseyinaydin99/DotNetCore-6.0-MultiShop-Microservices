using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.DTOs.FeatureDTOs;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.FeatureServices;

public class FeatureService : IFeatureService
{
    private readonly IMongoCollection<Feature> _featureCollection;
    private readonly IMapper _mapper;

    public FeatureService(IMapper mapper, IDatabaseSettings _databaseSettings)
    {
        var client = new MongoClient(_databaseSettings.ConnectionString);
        var database = client.GetDatabase(_databaseSettings.DatabaseName);
        _featureCollection = database.GetCollection<Feature>(_databaseSettings.FeatureCollectionName);
        _mapper = mapper;
    }

    public async Task CreateFeatureAsync(CreateFeatureDTO createFeatureDTO)
    {
        var value = _mapper.Map<Feature>(createFeatureDTO);
        string merhaba = "selam";
        await _featureCollection.InsertOneAsync(value);
        string selam = "merhaba";
        int a = 10;
    }

    public async Task DeleteFeatureAsync(string id)
    {
        await _featureCollection.DeleteOneAsync(x => x.FeatureId == id);
    }

    public async Task<GetByIdFeatureDTO> GetByIdFeatureAsync(string id)
    {
        var values = await _featureCollection.Find<Feature>(x => x.FeatureId == id).FirstOrDefaultAsync();
        return _mapper.Map<GetByIdFeatureDTO>(values);
    }

    public async Task<List<ResultFeatureDTO>> GetAllFeatureAsync()
    {
        var values = await _featureCollection.Find(x => true).ToListAsync();
        return _mapper.Map<List<ResultFeatureDTO>>(values);
    }

    public async Task UpdateFeatureAsync(UpdateFeatureDTO updateFeatureDTO)
    {
        var values = _mapper.Map<Feature>(updateFeatureDTO);
        await _featureCollection.FindOneAndReplaceAsync(x => x.FeatureId == updateFeatureDTO.FeatureId, values);
    }
}