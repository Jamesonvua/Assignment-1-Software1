var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // Change to add MVC support

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Show detailed error pages in development
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Map the routes for your controllers
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Set default route

// Route for AvailableEquipment
app.MapControllerRoute(
    name: "availableEquipment",
    pattern: "{controller=Request}/{action=AvailableEquipment}/{id?}");

// Route for AllEquipment
app.MapControllerRoute(
    name: "allEquipment",
    pattern: "{controller=Request}/{action=AllEquipment}/{id?}");

// Route for RequestForm
app.MapControllerRoute(
    name: "requestForm",
    pattern: "{controller=Request}/{action=RequestForm}/{id?}");

app.Run();
