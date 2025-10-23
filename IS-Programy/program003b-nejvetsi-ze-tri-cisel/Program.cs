string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************************************************");
    Console.WriteLine("************** Řazení Čiselné Řady Od Nejvetšího ***************");
    Console.WriteLine("****************************************************************");
    Console.WriteLine("********************* Daniel Rocha Pinheiro ********************");
    Console.WriteLine("************************** 16.10.2025 **************************");
    Console.WriteLine("****************************************************************");
    Console.WriteLine();

   
    Console.WriteLine("Zadejte celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte celé číslo A: ");
    }



  
    Console.WriteLine("Zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte celé číslo B: ");
    }

    Console.WriteLine("Zadejte celé číslo C: ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte celé číslo c: ");
    }


    Console.WriteLine();
    Console.Write("===================================================================\n");
    if (a > b)
    {
        if (a > c)
            Console.WriteLine($"Největsí čislo je A = {a}");
        else
            Console.WriteLine($"Největší číslo je C = {c}");
    }
    else
    {
        if (b > c)
            Console.WriteLine($"Největší číslo je B = {b}");
        else
            Console.WriteLine($"Největší číslo je C = {c}");
    }
    Console.Write("===================================================================\n");





    Console.Write("===================================================================\n");
    Console.Write($"Seřazená čísla od největšího: {a}, {b}, {c} ");
    Console.Write("\n=================================================================\n");




    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
    



}