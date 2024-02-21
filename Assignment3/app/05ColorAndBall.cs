namespace app1;
class Color
{
    private int red;
    private int green;
    private int blue;
    private int alpha;

    public Color(int red, int green, int blue, int alpha)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }

    public Color(int red, int green, int blue) : this(red, green, blue, 255)
    {
    }

    public int GetRed() => red;
    public void SetRed(int value) => red = value;
    public int GetGreen() => green;
    public void SetGreen(int value) => green = value;
    public int GetBlue() => blue;
    public void SetBlue(int value) => blue = value;
    public int GetAlpha() => alpha;
    public void SetAlpha(int value) => alpha = value;

    public int GetGrayscale()
    {
        return (red + green + blue) / 3;
    }
}

class Ball
{
    private int size;
    private Color color;
    private int throwCount;
    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
    }

    public void Pop()
    {
        size = 0;
    }

    public void Throw()
    {
        if (size != 0)
        {
            throwCount++;
        }
    }

    public int GetThrowCount()
    {
        return throwCount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Color red = new Color(255, 0, 0);
        Color blue = new Color(0, 0, 255);
        Color green = new Color(0, 255, 0);
        Ball ball1 = new Ball(10, red);
        Ball ball2 = new Ball(15, blue);
        Ball ball3 = new Ball(20, green);
        ball1.Throw();
        ball2.Throw();
        ball3.Throw();
        ball1.Throw();
        ball3.Throw();
        ball2.Pop();
        ball2.Throw();
        Console.WriteLine("Ball 1: " + ball1.GetThrowCount());
        Console.WriteLine("Ball 2: " + ball2.GetThrowCount());
        Console.WriteLine("Ball 3: " + ball3.GetThrowCount());
    }
}