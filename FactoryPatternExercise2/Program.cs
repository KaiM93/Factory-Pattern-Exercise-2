namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;

            do {
                Console.Clear();
                correctInput = true;

                Console.WriteLine("What database would you like to work with?");

                Console.WriteLine("Type: SQL");

                Console.WriteLine("Type: Mongo");

                Console.WriteLine("Type: List");

                userInput = Console.ReadLine();

                if(userInput != "SQL" && userInput != "Mongo"  && userInput != "List")
                {
                    correctInput = false;
                    Console.WriteLine("Bad Input.");
                    Thread.Sleep(1000);
                }

            } while (!correctInput); ;

            Console.Clear();

            IDataAccess DB = DataAccessFactory.GetDataAccessType(userInput);

            var products = DB.LoadData();
            DB.SaveData();

            foreach(var item in products)
            {
                Console.WriteLine($"Name: {item.Name} Price: {item.Price}");
            }
        }
    }
}
