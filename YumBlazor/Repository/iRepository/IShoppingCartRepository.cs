﻿using YumBlazor.Data;

namespace YumBlazor.Repository.iRepository
{
    public interface IShoppingCartRepository
    {
        public Task<bool> UpdateCartAsync(string userId, int productId, int updateBy);

        public Task<IEnumerable<ShoppingCart>> GetAllAsync(string? userId);

        public Task<bool> ClearCartAsync(string? userId);
    }
}
