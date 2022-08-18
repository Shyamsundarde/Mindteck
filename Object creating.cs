using System;
class fruits
{
    string Fruit_Name;
    public void Quality()
    {
        Console.WriteLine("Food is so delicious");
    }
    public void Price(int x)
    {
        Console.WriteLine("The price of the Fruit is" + "" + " " + x);
    }
    static void Main(string[] args)
    {
        fruits v = new fruits();
        v.Fruit_Name = "Mango";
        v.Quality();
        v.Price(120);
        Console.WriteLine(v.Fruit_Name = "Mango");
        Console.ReadLine();


    }
}