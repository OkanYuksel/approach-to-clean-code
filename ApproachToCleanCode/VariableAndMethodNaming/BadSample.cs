namespace ApproachToCleanCode.VariableAndMethodNaming;

public class BadSample
{
    public double DistanceKm(int x1, int y1, int x2, int y2)
    {
        return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    }
}