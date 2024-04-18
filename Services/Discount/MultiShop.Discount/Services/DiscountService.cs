using Dapper;
using MultiShop.Discount.Context;
using MultiShop.Discount.DTOs;

namespace MultiShop.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _context;

        public DiscountService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateDiscountCouponAsync(CreateDiscountCouponDTO createCouponDTO)
        {
            string query = "insert into Coupons (Code,Rate,IsActive,ValidDate) values (@code,@rate,@isActive,@validDate)";
            var parameters = new DynamicParameters();
            parameters.Add("@code", createCouponDTO.Code);
            parameters.Add("@rate", createCouponDTO.Rate);
            parameters.Add("@isActive", createCouponDTO.IsActive);
            parameters.Add("@validDate", createCouponDTO.ValidDate);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteDiscountCouponAsync(int id)
        {
            string query = "Delete From Coupons where CouponId=@couponId";
            var parameters = new DynamicParameters();
            parameters.Add("couponId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
        public async Task<List<ResultDiscountCouponDTO>> GetAllDiscountCouponAsync()
        {
            string query = "Select * From Coupons";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultDiscountCouponDTO>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdDiscountCouponDTO> GetByIdDiscountCouponAsync(int id)
        {
            string query = "Select * From Coupons Where CouponId=@couponId";
            var parameters = new DynamicParameters();
            parameters.Add("@couponId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdDiscountCouponDTO>(query, parameters);
                return values;
            }
        }

        public async Task<ResultDiscountCouponDTO> GetCodeDetailByCodeAsync(string code)
        {
            string query = "Select * From Coupons Where Code=@code";
            var parameters = new DynamicParameters();
            parameters.Add("@code", code);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<ResultDiscountCouponDTO>(query, parameters);
                return values;
            }
        }

        public int GetDiscountCouponCountRate(string code)
        {
            string query = "Select Rate From Coupons Where Code=@code";
            var parameters = new DynamicParameters();
            parameters.Add("@code", code);
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, parameters);
                return values;
            }
        }

        public async Task UpdateDiscountCouponAsync(UpdateDiscountCouponDTO updateCouponDTO)
        {
            string query = "Update Coupons Set Code=@code,Rate=@rate,IsActive=@isActive,ValidDate=@validDate where CouponId=@couponId";
            var parameters = new DynamicParameters();
            parameters.Add("@code", updateCouponDTO.Code);
            parameters.Add("@rate", updateCouponDTO.Rate);
            parameters.Add("@isActive", updateCouponDTO.IsActive);
            parameters.Add("@validDate", updateCouponDTO.ValidDate);
            parameters.Add("@couponId", updateCouponDTO.CouponId);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}