
using GameCatalogue.Api.Entities;

List<Game> games = new() {

    new Game() {
        Id = 1,
        Name = " Street Fighter II",
        Genre = "Fighting",
        Price = 25.99M,
        ReleaseDate = new DateTime(1991,2,1),
        ImageUri = "https://placehold.co/100"

    },

    new Game() {
        Id = 2,
        Name = "Naruto Ultimate Ninja Storm Connections",
        Genre = " Fighting",
        Price = 59.99M,
        ReleaseDate = new DateTime(2023,10,05),
        ImageUri = "https://placehold.co/100"
    },

    new Game() {
        Id = 3,
        Name = "FC24",
        Genre = "Football",
        Price = 85.99M,
        ReleaseDate = new DateTime(2023,09,15),
        ImageUri = "https://placehold.co/100"
    }


};

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
