using MultiShop.Discount.DTOs;

namespace MultiShop.Discount.Services
{
    public interface IDiscountService
    {
        Task<List<ResultDiscountCouponDTO>> GetAllDiscountCouponAsync();
        Task CreateDiscountCouponAsync(CreateDiscountCouponDTO createCouponDTO);
        Task UpdateDiscountCouponAsync(UpdateDiscountCouponDTO updateCouponDTO);
        Task DeleteDiscountCouponAsync(int id);
        Task<GetByIdDiscountCouponDTO> GetByIdDiscountCouponAsync(int id);
        Task<ResultDiscountCouponDTO> GetCodeDetailByCodeAsync(string code);
        int GetDiscountCouponCountRate(string code);
        Task<int> GetDiscountCouponCount();
    }
}