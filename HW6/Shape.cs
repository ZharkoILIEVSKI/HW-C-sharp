namespace HW6;
public class Shape
{
    public string Name
    {
        get
        {
            Console.WriteLine("Name e procitano...");
        }
        set
        {
            Console.WriteLine("Name e setirano...");
        }
    }
    public string Color { 
        get
        {
            Console.WriteLine("Color e procitano...");
        }
        set
        {
            Console.WriteLine("Color e setirano...");
        }}
    public int[] position = new int[2]{0,0};
    public virtual void getArea()
    {
        Console.WriteLine("There is no special implementation for area");
    }

    public virtual void getPerimeter()
    {
        Console.WriteLine("There is no special implementation for perimeter");
    }

    public static void Move()
    {
        position[0] = position[0] + 5;
        position[1] = position[1] + 5;
        Console.WriteLine("Nova posicija: " + position[0] + " , " + position[1]);
    }

}

