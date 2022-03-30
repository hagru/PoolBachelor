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
        Console.WriteLine("Returning status" + GameConfig.GameStart);
        return Results.Ok(GameConfig.GameStart); //Returns 200 code + table status
    }
    else
       Console.WriteLine("Returning status" + GameConfig.GameStart);
    return Results.Ok(GameConfig.GameStart); //Returns 200 code + table status

});

app.MapPost("/gamestart", (GameCon g) =>
{
    Console.WriteLine("Trying to start a game \n");
    GameConfig.GameID = g.gameid;
    GameConfig.Username1 = g.username1;
    GameConfig.Username2 = g.username2;
    GameConfig.PlayerID1 = g.playerid1;
    GameConfig.PlayerID2 = g.Playerid2;
    //GameConfig.Timestamp = g.timestamp;
    GameConfig.GameStart = false;
    return Results.Ok();


});

app.MapPost("/gamestop", (GameCon g) =>
{
    Console.WriteLine("Trying to stop a game \n");
    GameConfig.GameID = g.gameid;
    if (GameConfig.GameID == g.gameid) //Sånn vi sjekker parameteret som kommer inn ?
    {
        Console.WriteLine("Stopping game with gameid " + g.gameid);
        GameConfig.GameStart = false;
        //Her må vi sikkert gjøre noe mer for å stoppe vision systemet.
        return Results.Ok();
    }
    else
    {
        return Results.BadRequest();
        //Om ikke gameid som kommer i post requesten matcher den som er aktiv så send bad request tilbake.
        //Kanskje legge inn en sjekk om at gameid ikke null ?
    }
    
    


});

app.Run();

public class GameCon
{
    public int gameid { get; set; }
    public string username1 { get; set; }
    public string username2 { get; set; }
    public int playerid1 { get; set; }
    public int Playerid2 { get; set; }
    //public DateTime timestamp { get; set; }
}
