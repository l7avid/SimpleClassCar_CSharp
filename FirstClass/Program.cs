namespace FirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car aveo = new Car("Chevrolet Aveo", 400, "white");
            aveo.Drive();
            aveo.Details();

            Console.WriteLine("Press 1 to stop the car: ");
            string userInput = Console.ReadLine();
            if(userInput.Equals("1"))
            {
                aveo.Stop();
            }
            else
            {
                Console.WriteLine("Car is still driving");
            }
        }
    }
}