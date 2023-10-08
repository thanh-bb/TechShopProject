using Microsoft.AspNetCore.Components;
using TechShop.Models.Dtos;
using TechShop.Web.Services.Contracts;

namespace ShopOnline.Web.Pages
{
	public class ProductsByCategoryBase : ComponentBase
	{
		[Parameter]
		

		public string CategoryId { get; set; }
		[Inject]
		public IProductService ProductService { get; set; }

		
		[Inject]
		public IManageProductsLocalStorageService ManageProductsLocalStorageService { get; set; }

		public IEnumerable<ProductDto> Products { get; set; }
		public IEnumerable<ProductDto> CategoryItem { get; set; }
		public string CategoryName { get; set; }
		public string ErrorMessage { get; set; }

		protected override async Task OnParametersSetAsync()
		{
			try
			{
				CategoryItem = await ProductService.GetItemsByCategory(CategoryId);
				Products = await GetProductCollectionByCategoryId(CategoryId);
				

				if (Products != null && Products.Count() > 0)
				{
					var productDto = Products.FirstOrDefault(p => p.MaLoai == CategoryId);

					if (productDto != null)
					{
						var loai = CategoryItem.Where(s => s.MaLoai == CategoryId).Select(s=>s.TenLoai).FirstOrDefault();
						CategoryName = loai;
					}

				}
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
		}

		private async Task<IEnumerable<ProductDto>> GetProductCollectionByCategoryId(string categoryId)
		{
			var productCollection = await ManageProductsLocalStorageService.GetCollection();

			if (productCollection != null)
			{
				return productCollection.Where(p => p.MaLoai == categoryId);
			}
			else
			{
				return await ProductService.GetItemsByCategory(categoryId);
			}

		}

	

	}
}