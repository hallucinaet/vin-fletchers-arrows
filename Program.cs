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
    while (true)
    {
        Console.Write("Choose the arrowhead type - (1) Steel | (2) Wood | (3) Obsidian ");
        int option = Convert.ToInt32(Console.ReadLine());
        
        if (option >=1 && option <= 3)
        {
            return option switch
            {
                1 => Arrowhead.Steel,
                2 => Arrowhead.Wood,
                3 => Arrowhead.Obsidian
            };
        }
    }
}

Fletching GetFletchingType()
{
    while (true)
    {
        Console.Write("Choose the fletching type - (1) Plastic | (2) Turkey feathers | (3) Goose feathers ");
        int option = Convert.ToInt32(Console.ReadLine());

        if (option >= 1 && option <= 3)
        {
            return option switch
            {
                1 => Fletching.Plastic,
                2 => Fletching.TurkeyFeathers,
                3 => Fletching.GooseFeathers
            };
        }
    }
}

float GetLength()
{
    while (true)
    {
        Console.Write("Choose the length (60 to 100 cm): ");
        int option = Convert.ToInt32(Console.ReadLine());

        if (option >= 60 && option <= 100)
        {
            return option;
        }
    }
}

public class Arrow
{
    public Arrowhead Arrowhead { get; }
    public Fletching Fletching { get; }
    public float Length { get; } // Length in centimeters

    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = length;
    }

    public float GetCost()
    {
        float arrowheadCost = Arrowhead switch
        {
            Arrowhead.Steel => 10,
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5
        };

        float fletchingCost = Fletching switch
        {
            Fletching.Plastic => 10,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3
        };

        float lengthCost = Length * 0.05f;

        return arrowheadCost + fletchingCost + lengthCost;
    }
}

public enum Arrowhead { Steel, Wood, Obsidian }
public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }