using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StructExample
{
    public struct Rectangle
    {
        public int width;
        public int height;

      
        public void Area()
        {
            int area = height * width;
            Console.WriteLine($"Area of Rectangle {height}*{width} ={area}");

        }
    }
    public class Myclass
    {
        public static void Main()
        {
            Rectangle rect;
            Console.WriteLine("Enter Height");
            rect.height=int.Parse( Console.ReadLine() );
            Console.WriteLine("Enter Width");
            rect.width=int.Parse( Console.ReadLine() );
            rect.Area();
            Console.ReadKey();
        }
    }
 }
