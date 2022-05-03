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
app.MapPut("/UpdateTableStatus", (GameConfig g) =>
{
    //This changes the table status to true/false depending on the status.
    gamecon.GameStart = g.GameStart;
   
     
});
app.MapGet("/CheckTableStatus", () =>
{
    //This will retrun the table status. If there is an active game we return false else we return true.
    if (gamecon.GameStart == true)
    {
        Console.WriteLine("Returning status" + gamecon.GameStart);
        return Results.Ok(gamecon.GameStart); //Returns 200 code + table status
    }
    else
       Console.WriteLine("Returning status" + gamecon.GameStart);
    return Results.Ok(gamecon.GameStart); //Returns 200 code + table status

});
app.MapGet("/GetInfo", () =>
{   
    //This will return info about the active game (Usernames, playerids, gameid, etc).
    return Results.Ok(gamecon); //Returns 200 code + table status
});

app.MapPost("/GameStart", (GameConfig g) =>
{
    //This will recvied necessary gameinfo and start a game.
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

app.MapPut("/GameStop", (GameConfig g) =>
{
    //This will try to delete the active game if the received gameid matches the active gameid
    Console.WriteLine("Trying to stop the game.");
    gamecon.GameID = g.GameID;
    if (gamecon.GameID == g.GameID) 
    {
        Console.WriteLine("Stopping game with gameid " + g.GameID);
        gamecon.GameStop = true;
        gamecon.PlayerID1 = 0;
        gamecon.PlayerID2 = 0;
        gamecon.GameID = 0;
        gamecon.Username1 = "";
        gamecon.Username2 = "";
        gamecon.GameStart = true;
        return Results.Ok();
    }
    else
    {
        Console.WriteLine("GameID did not match active game. Returning bad request.");
        return Results.BadRequest();
        //If received gameid does not match the active gameid we return a 400 respons.
    }
});
app.Run();


