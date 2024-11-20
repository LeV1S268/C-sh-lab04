public class MyMatrix
{
    private double[,] matrix;
    private int rows;
    private int cols;
    public MyMatrix(int rows, int cols, double minValue, double maxValue)
    {  
        this.rows = rows;
        this.cols = cols;
        matrix = new double[rows, cols];
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.NextDouble() * (maxValue - minValue) + minValue;
            }
        }
    }
    public double this[int row, int col]
    {
        get => matrix[row, col];
        set => matrix[row, col] = value;
    }
    public static MyMatrix operator +(MyMatrix a, MyMatrix b)
    {
        MyMatrix result = new MyMatrix(a.rows, a.cols, 0, 0);
        for (int i = 0; i < a.rows; i++)
        {
            for (int j = 0; j < a.cols; j++)
            {
                result[i, j] = a[i, j] + b[i, j];
            }
        }
        return result;
    }
    public static MyMatrix operator -(MyMatrix a, MyMatrix b)
    {
        MyMatrix result = new MyMatrix(a.rows, a.cols, 0, 0);
        for (int i = 0; i < a.rows; i++)
        {
            for (int j = 0; j < a.cols; j++)
            {
                result[i, j] = a[i, j] - b[i, j];
            }
        }
        return result;
    }
    public static MyMatrix operator *(MyMatrix a, double scalar)
    {
        MyMatrix result = new MyMatrix(a.rows, a.cols, 0, 0);
        for (int i = 0; i < a.rows; i++)
        {
            for (int j = 0; j < a.cols; j++)
            {
                result[i, j] = a[i, j] * scalar;
            }
        }
        return result;
    }
    public static MyMatrix operator /(MyMatrix a, double scalar)
    {
        MyMatrix result = new MyMatrix(a.rows, a.cols, 0, 0);
        for (int i = 0; i < a.rows; i++)
        {
            for (int j = 0; j < a.cols; j++)
            {
                result[i, j] = a[i, j] / scalar;
            }
        }
        return result;
    }
    public void Print()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]:F2} ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество строк матрицы:");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов матрицы:");
        int cols = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите минимальное значение для случайных чисел:");
        double minValue = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите максимальное значение для случайных чисел:");
        double maxValue = double.Parse(Console.ReadLine());
        MyMatrix matrixA = new MyMatrix(rows, cols, minValue, maxValue);
        MyMatrix matrixB = new MyMatrix(rows, cols, minValue, maxValue);
        Console.WriteLine("\nМатрица A:");
        matrixA.Print();
        Console.WriteLine("\nМатрица B:");
        matrixB.Print();
        MyMatrix sumMatrix = matrixA + matrixB;
        Console.WriteLine("\nСумма матриц A и B:");
        sumMatrix.Print();
        MyMatrix diffMatrix = matrixA - matrixB;
        Console.WriteLine("\nРазность матриц A и B:");
        diffMatrix.Print();
        Console.WriteLine("\nВведите число для умножения матрицы A:");
        double scalar = double.Parse(Console.ReadLine());
        MyMatrix scaledMatrix = matrixA * scalar;
        Console.WriteLine($"\nМатрица A, умноженная на {scalar}:");
        scaledMatrix.Print();
        MyMatrix dividedMatrix = matrixA / scalar;
        Console.WriteLine($"\nМатрица A, разделённая на {scalar}:");
        dividedMatrix.Print();
    }
}
