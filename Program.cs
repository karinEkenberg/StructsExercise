namespace StructsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customers c1 = new Customers();
            c1.FirstName = "Svea";
            c1.LastName = "Andersson";
            c1.Balance = 2900;

            Customers c2;
            c2 = new Customers();
            c2.FirstName = "Bobo";
            c2.LastName = "Holm";
            c2.Balance = 1230;


            Console.WriteLine($"{c1.FirstName} {c1.LastName} - {c1.Balance} sek.");
            Console.WriteLine($"{c2.FirstName} {c2.LastName} - {c2.Balance} sek.");
        }
    }
}
