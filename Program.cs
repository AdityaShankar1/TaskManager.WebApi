using Microsoft.EntityFrameworkCore;   // EF Core for database access
using TaskManagerApi.Data;             // Your custom DbContext namespace

// Create a builder for the web application
var builder = WebApplication.CreateBuilder(args);

// -------------------- SERVICE CONFIGURATION --------------------

// Register your DbContext with SQLite
// "Data Source=tasks.db" means EF Core will create a local SQLite file named tasks.db
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=tasks.db"));

// Add support for controllers (MVC style)
// This lets you create Controllers folder with CRUD endpoints
builder.Services.AddControllers();

// Add Swagger/OpenAPI generator
// This automatically creates API documentation and a test UI at /swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// -------------------- BUILD APP --------------------
var app = builder.Build();

// -------------------- MIDDLEWARE PIPELINE --------------------

// Enable Swagger UI only in Development mode
// In production, you might disable it for security reasons
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Redirect HTTP → HTTPS for security
app.UseHttpsRedirection();

// Add authorization middleware (needed if you later add authentication/roles)
app.UseAuthorization();

// Map controller routes (e.g., /api/tasks)
// This tells ASP.NET Core to look for controllers and expose their endpoints
app.MapControllers();

// -------------------- RUN APP --------------------
// Starts the web server and listens on the configured port
app.Run();