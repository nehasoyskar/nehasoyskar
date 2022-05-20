using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program");
            operations ob = new operations();

            int Factorial = ob.factorial(3);
            Console.WriteLine("factorial="+Factorial);

            double Raised = ob.raised(3,2);
            Console.WriteLine("Raised="+Raised);

            //double Trignomentry = ob.trignomentry("Cos", 0);
            //double Trignomentry = ob.trignomentry("Sin", 0);
            double Trignomentry = ob.trignomentry("Tan", 45);
            Console.WriteLine("Trignomentry="+Trignomentry);

            //double Area = ob.area("Square",new double[] {4});
            // double Area = ob.area("Circle", new double[] {4,2});
           // double Area = ob.area("Triangle", new double[] { 4 });
            double Area = ob.area("Rectangle=", new double[] {4,2});
           
            Console.WriteLine("Area="+Area);

        
    }
        public class operations
        {
            public int factorial(int x)
            {
                int fact = 1;
                for (int i = 1; i <= x; i++)
                {

                    fact = fact * i;

                }
                return fact;
            }
            private bool valid(double x, double y)
            {
                if (x == 0 || y == 0)
                    return false;
                else
                    return true;
            }
            public double raised(double x, double y)
            {

                if (!valid(x, y)) return 0;
                double ans = Math.Pow(x, y);
                return ans;

            }
            public double trignomentry(string x, double y)
            {
                if (x == "Cos")
                {
                    double cos = Math.Cos(y);
                    return cos;
                }
                if (x == "Sin")
                {
                    double sin = Math.Sin(y);
                    return sin;
                }
                if (x == "Tan")
                {
                    double tan = Math.Tan(y);
                    return tan;
                }
                else return 0;
            }
            public double area(string x, double[] arr)
            {
                if (x == "Circle")
                {
                    double area = Math.PI * arr[0] * arr[0];
                    return area;
                }
                if (x == "Square")
                {
                    double area =arr[0]*arr[0];
                    return area;
                }
                if (x == "Rectangle")
                {
                    double area = arr[0] * arr[1];
                    return area;
                }
                if (x == "Tangle")
                {
                    double area = 0.5*arr[0] * arr[1];
                    return area;
                }
                else return 0;
            }




        }

    }
}
