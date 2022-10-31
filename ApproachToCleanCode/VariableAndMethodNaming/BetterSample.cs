namespace ApproachToCleanCode.VariableAndMethodNaming;

// anlamlı isimlendirmelere sahip
// telafuz edilebilir isimler tartışmayı kolaylaştırıyor
// searchable
// comment e ihtiyaç yok.
public class BetterSample
{
    public double CalculateDistanceInKmBetweenPoints(Point firstPoint, Point secondPoint)
    {
        return Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) + Math.Pow((firstPoint.Y - secondPoint.Y), 2));
    }
}

public class Point
{
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; private set; }
    public int Y { get; private set; }
}