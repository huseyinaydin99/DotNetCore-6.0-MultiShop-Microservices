using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.DTOs.CategoryDTOs;
using MultiShop.Catalog.DTOs.SpecialOfferDTOs;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.SpecialOfferServices;

public class SpecialOfferService : ISpecialOfferService
{
    private readonly IMongoCollection<SpecialOffer> _specialOfferCollection;
    private readonly IMapper _mapper;

    public SpecialOfferService(IMapper mapper, IDatabaseSettings _databaseSettings)
    {
        var client = new MongoClient(_databaseSettings.ConnectionString);
        var database = client.GetDatabase(_databaseSettings.DatabaseName);
        _specialOfferCollection = database.GetCollection<SpecialOffer>(_databaseSettings.SpecialOfferCollectionName);
        _mapper = mapper;
    }

    public async Task CreateSpecialOfferAsync(CreateSpecialOfferDTO createSpecialOfferDTO)
    {
        var value = _mapper.Map<SpecialOffer>(createSpecialOfferDTO);
        await _specialOfferCollection.InsertOneAsync(value);
    }

    public async Task DeleteSpecialOfferAsync(string id)
    {
        await _specialOfferCollection.DeleteOneAsync(x => x.SpecialOfferId == id);
    }

    public async Task<GetByIdSpecialOfferDTO> GetByIdSpecialOfferAsync(string id)
    {
        var values = await _specialOfferCollection.Find<SpecialOffer>(x => x.SpecialOfferId == id).FirstOrDefaultAsync();
        return _mapper.Map<GetByIdSpecialOfferDTO>(values);
    }

    public async Task<List<ResultSpecialOfferDTO>> GetAllSpecialOfferAsync()
    {
        var values = await _specialOfferCollection.Find(x => true).ToListAsync();
        return _mapper.Map<List<ResultSpecialOfferDTO>>(values);
    }

    public async Task UpdateSpecialOfferAsync(UpdateSpecialOfferDTO updateSpecialOfferDTO)
    {
        var values = _mapper.Map<SpecialOffer>(updateSpecialOfferDTO);
        await _specialOfferCollection.FindOneAndReplaceAsync(x => x.SpecialOfferId == updateSpecialOfferDTO.SpecialOfferId, values);
    }
}