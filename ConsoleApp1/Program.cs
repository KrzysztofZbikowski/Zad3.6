class Zad
{
    static void Main(string[] args)
    {
        double BMI, m, w;
        Console.WriteLine("Podaj swoją wagę w kilogramach: ");
        m = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj swój wzrost w metrach: ");
        w = double.Parse(Console.ReadLine());
        BMI = m / (Math.Pow(w, 2));
        Console.WriteLine("Twoje BMI wynosi: " + BMI);
        if (BMI < 16.0)
        {
            Console.WriteLine("Wygłodzenie");
        }
        else if (BMI < 17.0 && BMI >= 16.0)
        {
            Console.WriteLine("Wychudzenie");
        }
        else if (BMI < 18.5 && BMI >= 17.0)
        {
            Console.WriteLine("Niedowaga");
        }
        else if (BMI >= 18.5 && BMI <= 24.99)
        {
            Console.WriteLine("Waga prawidłowa");
        }
        else if (BMI >= 25.0 && BMI <= 29.99)
        {
            Console.WriteLine("Nadwaga");
        }
        else if (BMI >= 30.0 && BMI <= 34.99)
        {
            Console.WriteLine("otyłość I stopnia");
        }
        else if (BMI >= 35.0 && BMI <= 39.99)
        {
            Console.WriteLine("otyłość II stopnia");
        }
        else
        {
            Console.WriteLine("otyłość III stopnia");
        }
        Console.ReadKey();
    }
}