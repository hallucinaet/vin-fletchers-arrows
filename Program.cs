Arrow arrow = GetArrow();
Console.WriteLine($"Your new arrow costs {arrow.GetCost()} gold.");

Arrow GetArrow()
{
    Arrowhead arrowhead = GetArrowheadType();
    Fletching fletching = GetFletchingType();
    float length = GetLength();

    return new(arrowhead, fletching, length);
}

Arrowhead GetArrowheadType()
{
    Console.Write("Choose the arrowhead type (steel, wood, obsidian): ");

    return Console.ReadLine() switch
    {
        "steel" => Arrowhead.Steel,
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian,
    };
}

Fletching GetFletchingType()
{
    Console.Write("Choose the fletching type (plastic, turkey feathers, goose feathers): ");

    return Console.ReadLine() switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feathers" => Fletching.TurkeyFeathers,
        "goose feathers" => Fletching.GooseFeathers,
    };
}

float GetLength()
{
    Console.Write("Choose the length (60 to 100 cm): ");

    return Convert.ToInt32(Console.ReadLine());
}

class Arrow
{
    public Arrowhead _arrowhead;
    public Fletching _fletching;
    public float _length;


    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }

    public float GetCost()
    {
        float arrowheadCost = _arrowhead switch
        {
            Arrowhead.Steel => 10,
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5,
        };

        float fletchingCost = _fletching switch
        {
            Fletching.Plastic => 10,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3,
        };

        float lengthCost = _length * 0.05f;

        return arrowheadCost + fletchingCost + lengthCost;
    }
}

enum Arrowhead
{
    Steel,
    Wood,
    Obsidian
}

enum Fletching
{
    Plastic,
    TurkeyFeathers,
    GooseFeathers
}