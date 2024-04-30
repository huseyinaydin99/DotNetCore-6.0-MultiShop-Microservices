using MultiShop.Dto.DiscountDtos;

namespace MultiShop.WebUI.Services.DiscountServices;

public interface IDiscountService
{
    Task<GetDiscountCodeDetailByCode> GetDiscountCode(string code);
    Task<int> GetDiscountCouponCountRate(string code);
}