
class Calculating
{
    static void Main()
    {
        double[] xarray = { 0.2, 0.3, 0.38, 0.43, 0.57 };
        double x, y;
        int i;

        Console.WriteLine("First task: ");
        for (x = 0.11; x < 0.36; x += 0.05)
        {
            y = (Math.Pow(Math.Sin(x), 3) + Math.Pow(Math.Cos(x), 3)) * Math.Log(x);
            Console.WriteLine(y);
        }
        for (i = 0; i < 5; i++)
        {
            y = (Math.Pow(Math.Sin(xarray[i]), 3) + Math.Pow(Math.Cos(xarray[i]), 3)) * Math.Log(xarray[i]);
            Console.WriteLine(y);
        }
        Console.ReadKey();
    }
}