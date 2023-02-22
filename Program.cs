using System.Xml.Linq;

namespace Swap_Without_Third_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            float y = float.Parse(Console.ReadLine());
            x = x+y;
            y = x-y;
            x = x-y;
            
            Console.WriteLine("The First Number After Swap:"+x);
            Console.WriteLine("The Second Number After Swap:"+y);


        }
    }
}