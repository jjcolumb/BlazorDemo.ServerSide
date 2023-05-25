using BlazorDemo.Services;
using Microsoft.Extensions.DependencyInjection;

public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        // ...
        services.AddSingleton<IStockQuoteService, StockQuoteService>();
    }
}
