class Program
{

 public static void Main()
    {

        int num;

        Console.WriteLine("Escreva um numuero: ");
        string info = Console.ReadLine();
        num = Convert.ToInt32(info);

        if (num % 2 == 0)
        {
            Console.WriteLine("É par");
        }
        else
        {
            Console.WriteLine("É impar");
        }


    }

}
   