namespace S25Week2IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            string str = "hello";
            Circle c1 = new Circle();
            c1.radius = 5;
            int[] arr = { 3, 5, 7, 5, 3 };

            Console.WriteLine("Before changes:\n");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
            Console.WriteLine("radius = " + c1.radius);
            Console.WriteLine("arr[0] = " + arr[0]);

            ChangeValue(ref num, str, c1, arr);

            Console.WriteLine("\n\nAfter changes:\n");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
            Console.WriteLine("radius = " + c1.radius);
            Console.WriteLine("arr[0] = " + arr[0]);

            Console.WriteLine("\n\n");



            // output parameter example
            double r = 5;
            //double circum, area;

            CalculateCircumAndArea(r, out double circum, out double area);

            Console.WriteLine("Circumference = " + circum.ToString("F2"));
            Console.WriteLine("Area = " + area.ToString("F2"));
        }

        // output parameters example
        static void CalculateCircumAndArea(double r, out double circum, out double area)
        {
            circum = 2 * Math.PI * r;
            area = Math.PI * r * r;
        }




        static void ChangeValue(ref int n, string s, Circle c, int[] a)
        {
            n = 100;
            s = "bye";
            c.radius = 100;
            a[0] = 100;
        }
    }

    class Circle
    {
        public int radius;
    }
}
