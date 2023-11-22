
namespace AsteroidsProject;


internal class Card(CardColors color, CardRanks rank)
{
    public readonly CardColors Color = color;
    public readonly CardRanks Rank = rank;

    public bool IsSymbol =>
        Rank == CardRanks.Ampersand || Rank == CardRanks.Caret || 
        Rank == CardRanks.DollarSign || Rank == CardRanks.Percent;
    public bool IsNumber => !IsSymbol;
    
}

public enum CardColors
{
    Red,
    Green,
    Blue,
    Yellow,
}

public enum CardRanks
{
    First = 1,
    Second,
    Third,
    Fourth,
    Fifth,
    Sixth,
    Seventh,
    Eighth,
    Ninth,
    Tenth,
    DollarSign,
    Percent,
    Caret,
    Ampersand,
}
