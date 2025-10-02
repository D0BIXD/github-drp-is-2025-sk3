string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("************** Výpis číselne řady **************");
    Console.WriteLine("************************************************");
    Console.WriteLine("************* Daniel Rocha Pinheiro ************");
    Console.WriteLine("****************** 02.10.2025 ******************");
    Console.WriteLine("************************************************");
    Console.WriteLine();

    // Vstup číselné hodnoty do programu - špatné řešení
    // Console.Write("Zadejte první číslo řady: ");
    // int first = int.Parse(Console.ReadLine());

    // Vstup číselné hodnoty do programu - lepší řešení
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
    



}