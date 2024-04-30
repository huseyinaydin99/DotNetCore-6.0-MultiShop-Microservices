using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.DTOs.OfferDiscountDTOs;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.OfferDiscountServices;

public class OfferDiscountService: IOfferDiscountService
{
    private readonly IMongoCollection<OfferDiscount> _offerDiscountCollection;
    private readonly IMapper _mapper;

    public OfferDiscountService(IMapper mapper, IDatabaseSettings _databaseSettings)
    {
        var client = new MongoClient(_databaseSettings.ConnectionString);
        var database = client.GetDatabase(_databaseSettings.DatabaseName);
        _offerDiscountCollection = database.GetCollection<OfferDiscount>(_databaseSettings.OfferDiscountCollectionName);
        _mapper = mapper;
    }

    public async Task CreateOfferDiscountAsync(CreateOfferDiscountDTO createOfferDiscountDTO)
    {
        var value = _mapper.Map<OfferDiscount>(createOfferDiscountDTO);
        await _offerDiscountCollection.InsertOneAsync(value);
    }

    public async Task DeleteOfferDiscountAsync(string id)
    {
        await _offerDiscountCollection.DeleteOneAsync(x => x.OfferDiscountId == id);
    }

    public async Task<GetByIdOfferDiscountDTO> GetByIdOfferDiscountAsync(string id)
    {
        var values = await _offerDiscountCollection.Find<OfferDiscount>(x => x.OfferDiscountId == id).FirstOrDefaultAsync();
        return _mapper.Map<GetByIdOfferDiscountDTO>(values);
    }

    public async Task<List<ResultOfferDiscountDTO>> GetAllOfferDiscountAsync()
    {
        var values = await _offerDiscountCollection.Find(x => true).ToListAsync();
        return _mapper.Map<List<ResultOfferDiscountDTO>>(values);
    }

    public async Task UpdateOfferDiscountAsync(UpdateOfferDiscountDTO updateOfferDiscountDTO)
    {
        var values = _mapper.Map<OfferDiscount>(updateOfferDiscountDTO);
        await _offerDiscountCollection.FindOneAndReplaceAsync(x => x.OfferDiscountId == updateOfferDiscountDTO.OfferDiscountId, values);
    }
}