namespace task_1
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Введіть число х: ");
            int x =Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть число у: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x + " + " + y + " = " + (x+y));

            Console.ReadKey();

        }
    }
}
