namespace Circle_objects_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ShowCirlceMeasurments();
            
        }



        static double Validator()
        {
            while (true)
            {
                Console.WriteLine("Enter the radius of your circle");
                string userRadius = Console.ReadLine();
                if (double.TryParse(userRadius, out double radius))
                {
                    return radius;
                }

                Console.WriteLine("Invalid input, press and key to try again");
                Console.ReadKey();
                Console.Clear();
            }
            
        }

        static void ShowCirlceMeasurments()
        {
            double radius = Validator();
            Circle userCircle = new Circle(radius);

            Console.WriteLine($"Radius: {userCircle.GetRadius()}");
            Console.WriteLine($"Diameter: {userCircle.Diameter}");
            Console.WriteLine($"Area: {userCircle.Area}");
            while (true)
            {
                Console.WriteLine("Do you want to grow your circle? yes/no");
                string anwser = Console.ReadLine().ToUpper().Trim();
                if (anwser.Equals("YES"))
                {
                    userCircle.Grow();
                    Console.WriteLine($"Radius: {userCircle.GetRadius()}");
                    Console.WriteLine($"Diameter: {userCircle.Diameter}");
                    Console.WriteLine($"Area: {userCircle.Area}");
                }
                else
                {
                    Console.WriteLine("Later nerd");
                    break;
                }
            }
        }

    }
}