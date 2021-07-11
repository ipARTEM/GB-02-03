using System;
using System.Diagnostics;

namespace GB_02_03
{

    class PointClass
    {
        public float X { get; set; }

        public float Y { get; set; }
    }

    struct PointStruct
    {
        public float X { get; set; }

        public float Y { get; set; }
    }

    struct PointStructDouble
    {
        public double X { get; set; }

        public double Y { get; set; }
    }

    struct PointStructWithoutSquare
    {
        public float X { get; set; }

        public float Y { get; set; }
    }


    class Program
    {
        static Stopwatch sw;

        static void NumberPoints(int n)
        {
            for (int i = 0; i < n; i++)
            {
                RandomPoints();

            }

        }




        static void RandomPoints()
        {
            var x = new Random();
            var y = new Random();
            

            PointClass pointClass1 = new PointClass();
            PointStruct pointStruct1 = new PointStruct();
            PointStructDouble pointStructDouble1 = new PointStructDouble();
            PointStructWithoutSquare pointStructWithoutSquare1 = new PointStructWithoutSquare();  

            pointClass1.X=x.Next(0, 100_000_000);
            pointStruct1.X = pointClass1.X;
            pointStructDouble1.X = pointStructDouble1.X;
            pointStructWithoutSquare1.X = pointClass1.X;

            pointClass1.Y = y.Next(0, 100_000_000);
            pointStruct1.Y = pointClass1.Y;
            pointStructDouble1.Y = pointStructDouble1.Y;
            pointStructWithoutSquare1.Y = pointClass1.Y;

            PointClass pointClass2 = new PointClass();
            PointStruct pointStruct2 = new PointStruct();
            PointStructDouble pointStructDouble2 = new PointStructDouble();
            PointStructWithoutSquare pointStructWithoutSquare2 = new PointStructWithoutSquare();

            pointClass2.X = x.Next(0, 100_000_000);
            pointStruct2.X = pointClass1.X;
            pointStructDouble2.X = pointStructDouble1.X;
            pointStructWithoutSquare2.X = pointClass1.X;

            pointClass2.Y = y.Next(0, 100_000_000);
            pointStruct2.Y = pointClass1.Y;
            pointStructDouble2.Y = pointStructDouble1.Y;
            pointStructWithoutSquare2.Y = pointClass1.Y;

            sw = new Stopwatch();

            PointDistance(pointClass1, pointClass2);
            PointDistance(pointStruct1, pointStruct2);
            PointDistance(pointStructDouble1, pointStructDouble2);
            PointDistance(pointStructWithoutSquare1, pointStructWithoutSquare2);
            Console.WriteLine();
        }

        public static void PointDistance(PointClass point1, PointClass point2)
        {
            float x = point1.X - point2.X;
            float y = point1.Y - point2.Y;
            
            sw.Start();

            MathF.Sqrt((x * x) + (y * y));
            sw.Stop();
            Console.Write($" {sw.ElapsedTicks}       ");

        }

        public static void PointDistance(PointStruct point1, PointStruct point2)
        {
            float x = point1.X - point2.X;
            float y = point1.Y - point2.Y;
            
            sw.Start();

            MathF.Sqrt((x * x) + (y * y));
            sw.Stop();
            Console.Write($" {sw.ElapsedTicks}       ");
        }

        public static void PointDistance(PointStructDouble point1, PointStructDouble point2)
        {
            double x = point1.X - point2.X;
            double y = point1.Y - point2.Y;
            
            sw.Start();

            Math.Sqrt((x * x) + (y * y));
            sw.Stop();
            Console.Write($" {sw.ElapsedTicks}       ");
        }

        public static void PointDistance(PointStructWithoutSquare point1, PointStructWithoutSquare point2)
        {
            float x = point1.X - point2.X;
            float y = point1.Y - point2.Y;
            
            sw.Start();

            MathF.Sqrt((x * x) + (y * y));
            sw.Stop();
            Console.Write($" {sw.ElapsedTicks}       ");
        }


        static void Main(string[] args)
        {

            Console.WriteLine("***********************************Тестирование***********************************");

            Console.WriteLine(" PointClass         PointStruct         PointStructDouble         PointStructWithoutSquare");

            NumberPoints(20);


        }
    }
}
