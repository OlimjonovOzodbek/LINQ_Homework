namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Methods.WorkerList();
            Console.WriteLine("\n--------------------------------------------------\n");
            Console.WriteLine("Workers who know C#");

            Methods.WorkerListByLanguageName();
        }
    }
}
