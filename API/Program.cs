using API_Class;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
////app.Urls.Add("");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Urls.Add("http://10.8.0.2:80");

// Comment
GameConfig gamecon = new GameConfig();
app.MapPut("/update", (GameConfig g) =>
{

    gamecon.GameStart = g.GameStart;
   
     
});
app.MapPut("/GameDone", () =>
{
    gamecon.GameStop = true;
    gamecon.PlayerID1 = 0;
    gamecon.PlayerID2 = 0;
    gamecon.GameID = 0;
    gamecon.Username1 = "";
    gamecon.Username2 = "";
    gamecon.GameStart = true;
    Console.WriteLine("ok");
    return Results.Ok();

});
app.MapGet("/checktable", () =>
{
    
    if (gamecon.GameStart == true)
    {
        Console.WriteLine("Returning status" + gamecon.GameStart);
        return Results.Ok(gamecon.GameStart); //Returns 200 code + table status
    }
    else
       Console.WriteLine("Returning status" + gamecon.GameStart);
    return Results.Ok(gamecon.GameStart); //Returns 200 code + table status

});
app.MapGet("/getinfo", () =>
{
    
    return Results.Ok(gamecon); //Returns 200 code + table status

});

app.MapPost("/gamestart", (GameConfig g) =>
{
    Console.WriteLine("Trying to start a game \n");
    gamecon.GameID = g.GameID;
    gamecon.Username1 = g.Username1;
    gamecon.Username2 = g.Username2;
    gamecon.PlayerID1 = g.PlayerID1;
    gamecon.PlayerID2 = g.PlayerID2;
    gamecon.Timestamp = DateTime.Now;
    gamecon.GameStart = false;
    return Results.Ok();


});

app.MapPost("/gamestop", (GameConfig g) =>
{
    Console.WriteLine("Trying to stop a game \n");
    gamecon.GameID = g.GameID;
    if (gamecon.GameID == g.GameID) //Sånn vi sjekker parameteret som kommer inn ?
    {
        Console.WriteLine("Stopping game with gameid " + g.GameID);
        gamecon.GameStart = false;
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


