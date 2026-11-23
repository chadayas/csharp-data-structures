using DotNetEnv;

Env.Load();

var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
await using var dataSrc = NpgsqlDataSource.Create(connStr);


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
   options.AddDefaultPolicy(policy =>
   {
      policy.WithOrigins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod();
   });
});

var app = builder.Build();

app.UseCors();


string[] fortunes =
{
    "The path you fear may lead to the life you seek.",
    "A small opportunity today may become a great success tomorrow.",
    "Your patience will soon be rewarded in an unexpected way.",
    "The wisest person in the room is often the one asking questions.",
    "Fortune favors those who prepare before opportunity knocks.",
    "A conversation with a stranger will change your perspective.",
    "What seems like a setback today may become your greatest advantage.",
    "The seed of your next success is hidden in your current struggle.",
    "Do not mistake a slow beginning for an unsuccessful journey.",
    "An unexpected turn will bring you closer to something you've long desired."
};

app.MapGet("/api/fortune", () => {
             
      int randNum = Random.Shared.Next(fortunes.Length);
      string sentence = fortunes[randNum];      

      return Results.Ok(new FortuneDto(sentence)); 
      }
);

app.Run();

record FortuneDto(string sentence);
