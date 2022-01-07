class Vectors
{
    static void Main()
    {
        Console.WriteLine("Enter coordinates of the second vector: ");
        int x = 1, y = 5, z = 3, X = Convert.ToInt32(Console.ReadLine()), Y = Convert.ToInt32(Console.ReadLine()), Z = Convert.ToInt32(Console.ReadLine());
        Calculating answer = new Calculating(x, y, z, X, Y, Z);
        Console.WriteLine($"Length of the vector: {answer.Length()}");
        answer.UnitVector();
        answer.ScalarProduct();
        answer.VectorsProduct();
    }
} 

class Calculating
{
    public int x, y, z, X, Y, Z;
    public double Length()
    {
        double length = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        return length;
    }

    public void UnitVector()
    {
        double[] unitvector = new double [3];
        int i;
        string[] value = { "x", "y", "z" };
        unitvector[0] = x / Length();
        unitvector[1] = y / Length();
        unitvector[2] = z / Length();
        for (i = 0; i < 3; i++)
        {
            Console.WriteLine($"Unit vector{value[i]}: { unitvector[i]}");
        }
    }

    public void ScalarProduct() 
    {
        double scalarproduct = X * x + Y * y + Z * z;
        Console.WriteLine($"Scalar product: {scalarproduct}");
    }

    public void VectorsProduct()
    {
        double[] vectorsproduct = { 0, 0, 0 };
        int i;
        string[] value = { "x", "y", "z" };
        vectorsproduct[0] = y * Z - z * Y;
        vectorsproduct[1] = x * Z - X * z;
        vectorsproduct[2] = x * Y - X * y;
        for (i = 0; i < 3; i++)
        {
            Console.WriteLine($"Vectors product: {value[i]} = {vectorsproduct[i]}");
        }
    }

    public Calculating()
    {
        x = y = z = X = Y = Z = 0;
    }

    public Calculating(int x, int y, int z, int X, int Y, int Z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.X = X;
        this.Y = Y;
        this.Z = Z;
    }
}