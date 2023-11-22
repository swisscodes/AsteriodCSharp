// See https://aka.ms/new-console-template for more information

using AsteroidsProject;



Asteroid astd = new(4, 5, 6, 6);
Console.WriteLine(astd.PositionX);
Asteroid[] asteroids =
[
    new Asteroid(100, 200, -4, -2),
    new Asteroid(-50, 100, -1, +3),
    new Asteroid(0, 0, 2, 1),
    new Asteroid(400, -100, -3, -1),
    new Asteroid(200, -300, 0, 3),
];

AsteroidsGame game = GetGame(asteroids);
//game.Run();

static AsteroidsGame GetGame(Asteroid[] asteroids)
{
    return new AsteroidsGame(asteroids);
}

Point point = new(13, 55);
Point point1 = new();
Console.WriteLine($"Point 1 X: {point.PointX} Y:  {point.PointY}");
Console.WriteLine($"Point 2 X: {point1.PointX} Y:  {point1.PointY}");

Color random = new((23, 87, 255));
Color fixedColor = Color.Orange;

Console.WriteLine($"R={random.R} G={random.G} B={random.B}");
Console.WriteLine($"R={fixedColor.R} G={fixedColor.G} B={fixedColor.B}");



foreach (CardColors color in Enum.GetValues<CardColors>())
{
    foreach (CardRanks rank in Enum.GetValues<CardRanks>())
    {
        Card card = new(color, rank);
        Console.WriteLine($"The {card.Color} {card.Rank}");
        Console.WriteLine($"The is {card.IsNumber}");
        Console.WriteLine($"The is {card.IsSymbol}");
    }
}

TheLockedDoor lockObj = new(1234);

string? nullable = string.Empty;

do
{
    lockObj.PerformAction();
    nullable = Console.ReadLine();
} while (nullable != string.Empty);

Console.WriteLine(PasswordValidator.Validate("Swissbobooiytre1"));

