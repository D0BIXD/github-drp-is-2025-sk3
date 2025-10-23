string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************************************************");
    Console.WriteLine("************************** Obdelník ****************************");
    Console.WriteLine("****************************************************************");
    Console.WriteLine("********************* Daniel Rocha Pinheiro ********************");
    Console.WriteLine("************************** 16.10.2025 **************************");
    Console.WriteLine("****************************************************************");
    Console.WriteLine();

   
    Console.WriteLine("Zadejte šířku obdélníku: ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte šířku obdélníka znovu: ");
    }


    Console.WriteLine("Zadejte výšku obdélníku: ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte výšku obdélníka znovu: ");
    }
  





    for(int i = 1; i <= height; i++) 
    {
        for (int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(500));
        }
        Console.WriteLine();
}







        Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
    



}