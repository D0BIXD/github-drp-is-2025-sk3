string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************************************************");
    Console.WriteLine("*************************** Max/Min ****************************");
    Console.WriteLine("****************************************************************");
    Console.WriteLine("********************* Daniel Rocha Pinheiro ********************");
    Console.WriteLine("************************** 16.10.2025 **************************");
    Console.WriteLine("****************************************************************");
    Console.WriteLine();
  
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("================================================");

    // Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    // záporná, kladná, nuly
    int negativeNumbs = 0; //záporná čísla
    int positiveNumbs = 0; //kladná čísla
    int zeros = 0; //nuly

    // sudá a lichá
    int evenNumbs = 0;
    int oddNumbs = 0;




    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandNumbs[i]);

        /*if (myRandNumbs[i] < 0)
            negativeNumbs++;
        if (myRandNumbs[i] > 0)
            positiveNumbs++;
        if (myRandNumbs[i] == 0)
            zeros++;            */

        if (myRandNumbs[i] < 0)
            negativeNumbs++;
        else if (myRandNumbs[i] > 0)
            positiveNumbs++;
        else
            zeros++;

        if (myRandNumbs[i] % 2 == 0)
            evenNumbs++;
        else
            oddNumbs++;    

    }

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("=============================================");
    Console.WriteLine("Počet záporných: {0}", negativeNumbs);
    Console.WriteLine("Počet kladných: {0}", positiveNumbs);
    Console.WriteLine("Počet nul: {0}", zeros);
    Console.WriteLine("=============================================");
    Console.WriteLine("Počet sudých: {0}", evenNumbs);
    Console.WriteLine("Počet lichých: {0}", oddNumbs);
    Console.WriteLine("=============================================");
    Console.WriteLine("=============================================");


// Hledání maxima, pozice maxima, minima a pozice minima
int max = myRandNumbs[0];
int min = myRandNumbs[0];
int posMax = 0;
int posMin = 0;


for(int i=0; i < n; i++)
    {
        if(myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }
        
        if(myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];    
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"pozice maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"pozice minima: {posMin}");
    Console.WriteLine("=============================================");
    Console.WriteLine();

    // Vykreslení přesýpacích hodin

    if(max >= 3)
    {
    if (max >= 3)
{
    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine();
    Console.WriteLine($"Přesýpací hodiny o velikosti {max}");
    Console.WriteLine();

    // Tento cyklus se stará o to, aby vykreslil správný počet řádků
    for (int i = 0; i < max; i++)
    {
        int spaces, stars;

        if (i < max / 2)
        {
            // horní polovina
            spaces = i;
            stars = max - 2 * i;
        }
        else
        {
            // dolní polovina
            spaces = max - i - 1;

            if (max % 2 == 1)
                stars = 2 * (i - max / 2) + 1;
            else
                stars = 2 * (i - max / 2) + 2;
        }
        
        // Tyto dva cykly musí být uvnitř stejného bloku
        for (int sp = 0; sp < spaces; sp++)
            Console.Write(" ");

        for (int st = 0; st < stars; st++)
            Console.Write("*");

        Console.WriteLine(); 
    }
}
else
{
    Console.WriteLine("Maximum je menší než 3 => obrazec se nebude vykreslovat");
}






        Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
}