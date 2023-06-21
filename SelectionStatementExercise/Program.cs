namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();

            var favNumber = r.Next(15);
            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());


            if (userInput == 7)
            {
                Console.WriteLine("This is your number");
            }
            else if (userInput >= 7)
            {
                Console.WriteLine("Too high");
                
            }
            else if (userInput <= 7)
            {
                Console.WriteLine("Too low"); 
            }
            else
            {
                Console.WriteLine("Can't use this number");
               
            }
        }
    }
}
