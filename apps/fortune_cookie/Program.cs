var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddCors(options =>
{
   policy.WithOrgins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod();
});

app.UseCors();

record UserDto(int Id, string Name);



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


app.MapGet("/", () => {
         return Results.Ok(new UserDto(Id, "Chad")); 
       }
);

app.MapGet("/", () => {
         int randNum = Random.Shared.Next(fortunes.Length);
         string sentence = fortunes[randNum];      
         return sentence; 
       }
);

app.Run();
