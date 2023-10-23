using TechShop.Models.Dtos;
using TechShop.Web.Services.Contracts;

namespace TechShop.Web.Services
{
    public class ManageCartItemsLocalStorageService : IManageCartItemsLocalStorageService
    {
        public Task<List<CartItemDto>> GetCollection()
        {
            throw new NotImplementedException();
        }

        public Task RemoveCollection()
        {
            throw new NotImplementedException();
        }

        public Task SaveCollection(List<CartItemDto> cartItemDtos)
        {
            throw new NotImplementedException();
        }
    }
}
