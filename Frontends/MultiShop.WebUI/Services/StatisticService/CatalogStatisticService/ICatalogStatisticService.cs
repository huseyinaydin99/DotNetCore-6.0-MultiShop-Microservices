namespace MultiShop.WebUI.Services.StatisticService.CatalogStatisticService;

public interface ICatalogStatisticService
{
    Task<long> GetCategoryCount();
    Task<long> GetProductCount();
    Task<long> GetBrandCount();
    Task<decimal> GetProductAvgPrice();
    Task<string> GetMaxPriceProductName();
    Task<string> GetMinPriceProductName();
}