using NpHttpServerApp;

List<Flight> flights = new()
{
    new("ASD-987", "Novosibirsk", new DateOnly(2024, 10, 22), new TimeOnly(19, 45)),
    new("PTR-01", "Vladivostok", new DateOnly(2024, 11, 5), new TimeOnly(11, 10)),
    new("ASD-987", "Krasnoyarsk", new DateOnly(2024, 11, 19), new TimeOnly(22, 30)),
};


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// get all
app.MapGet("/api/flights", () => flights);

// get one
app.MapGet("/api/flights/{id}", (int id) =>
{
    Flight? flight = flights.FirstOrDefault(f => f.Id == id);
    if (flight is null)
        return Results.NotFound(new { Message = "Flight not found " });

    return Results.Json(flight);
});

// insert
app.MapPost("/api/flights", (Flight flight) =>
{
    flight.Id = ++Flight.GlobalId;
    flights.Add(flight);

    return flight;
});

// update
app.MapPut("/api/flights", (Flight flightClient) =>
{
    Flight? flight = flights.FirstOrDefault(f => f.Id == flightClient.Id);
    if(flight is null)
        return Results.NotFound(new { Message = "Flight not found " });

    flight.Title = flightClient.Title;
    flight.ToCity = flightClient.ToCity;
    flight.Date = flightClient.Date;
    flight.Time = flightClient.Time;

    return Results.Json(flight);
});

// delete
app.MapDelete("/api/flights/{id}", (int id) =>
{
    Flight? flight = flights.FirstOrDefault(f => f.Id == id);
    if(flight is null)
        return Results.NotFound(new { Message = "Flight not found " });

    flights.Remove(flight);

    return Results.Json(flight);
});

app.Run();
