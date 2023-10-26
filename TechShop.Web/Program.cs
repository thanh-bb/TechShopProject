using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShopOnline.Web.Services;
using TechShop.Web;
using TechShop.Web.Services;
using TechShop.Web.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44368/") });

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IManageProductsLocalStorageService, ManageProductsLocalStorageService>();
builder.Services.AddScoped<ITinhTrangService, TinhTrangService>();  
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();	

//builder.Services.AddScoped<IFileUpLoadService, FileUpLoadService>();    

//local storage
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
builder.Services.AddScoped<IAuthService, AuthService>();

//Toast message
builder.Services.AddBlazoredToast();

await builder.Build().RunAsync();
