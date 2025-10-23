string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("************** Výpis číselne řady **************");
    Console.WriteLine("************************************************");
    Console.WriteLine("************* Daniel Rocha Pinheiro ************");
    Console.WriteLine("****************** 16.10.2025 ******************");
    Console.WriteLine("************************************************");
    Console.WriteLine();

   
    Console.Write("Zadejte celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo A: ");
    }



  
    Console.Write("Zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo B: ");
    }


    Console.WriteLine();
    int pom;
    if (a > b)
    {
        pom = a;
        a = b;
        b = pom;
        Console.WriteLine("Došlo k prohození proměnných...");

    }

    Console.Write("=================================================================\n");
    Console.Write($"Seřazená čísla: {a}, {b} ");
    Console.Write("\n=================================================================\n");











    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
    



}