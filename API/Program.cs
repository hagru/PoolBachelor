using API_Class;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Comment

app.MapGet("/checktable", () =>
{
    if (GameConfig.GameStart == true)
    {
        
        return GameConfig.GameStart;
    }
    else
        return GameConfig.GameStart;
});

app.MapPost("/gamestart", (GameCon g) =>
{
    GameConfig.GameID = g.gameid;
    GameConfig.Username1 = g.username1;
    GameConfig.Username2 = g.username2;
    GameConfig.PlayerID1 = g.playerid1;
    GameConfig.PlayerID2 = g.Playerid2;
    GameConfig.Timestamp = g.timestamp;
    GameConfig.GameStart = false;
});

app.Run();

public class GameCon
{
    public int gameid { get; set; }
    public string username1 { get; set; }
    public string username2 { get; set; }
    public int playerid1 { get; set; }
    public int Playerid2 { get; set; }
    public DateTime timestamp { get; set; }
}
