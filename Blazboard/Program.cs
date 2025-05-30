var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<NavMenuStateService>();
builder.Services.AddSingleton<ThemeService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var host = builder.Build();

var js = host.Services.GetRequiredService<IJSRuntime>();
var result = await js.InvokeAsync<string>("localStorage.getItem", "culture");
var culture = result is not null ? new CultureInfo(result) : new CultureInfo("en");

CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

await builder.Build().RunAsync();
