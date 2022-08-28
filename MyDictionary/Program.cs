namespace MyDictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> fruits = new MyDictionary<string, string>();
            fruits.Add("red", "Apple");
            fruits.Add("yellow", "Banana");
            fruits.Add("green", "Lime");

            fruits.Print();
            
        }

    }
}