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

            ChangeValue(n: num, s: str, c1, arr);

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

            Console.WriteLine("\n\n");




            //Console.Write("Enter a number: ");
            //if (int.TryParse(Console.ReadLine(), out int n))
            //    Console.WriteLine("n = " + n);
            //else
            //    Console.WriteLine("Invalid input. Please try again.");

            //Console.WriteLine("\n\n");




            // parameter array

            int a = 3, b = 5, c = 8;
            Console.WriteLine("a = " + a + " b = " + b + " c = " + c);
            Console.WriteLine($"a = {a} b = {b} c = {c}");
            Console.WriteLine("a = {0} b = {1} c = {2}", a, b, c);


            int[] myArr = { 3, 5, 6, 8, 3, 2 };

            PrintArray(myArr);
            PrintArray(3,4,5,6,6,8,8,7,5,4,33);




            PersonInfo("John", 34);
            PersonInfo(age: 23, name: "John");
            PersonInfo("John");
        }


        static void PersonInfo(string name, int age = 21)
        {
            // method body
        }




        // parameter array example
        static void PrintArray(params int[] a)
        {
            Console.WriteLine("\n\nNumber of items: " + a.Length);

            foreach (int i in a)
                Console.Write(i + " ");
            Console.WriteLine();
        }




        // output parameters example
        static void CalculateCircumAndArea(double r, out double circum, out double area)
        {
            circum = 2 * Math.PI * r;
            area = Math.PI * r * r;
        }




        static void ChangeValue(int n, string s, Circle c, int[] a)
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
