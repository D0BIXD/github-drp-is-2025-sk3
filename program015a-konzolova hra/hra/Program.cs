using System;
{
    
    Console.WriteLine();
    Console.WriteLine("===============================================");
    Console.WriteLine("===============================================");
    Console.WriteLine("============= Kámen, nůžky, papír =============");
    Console.WriteLine("============ Daniel Rocha Pinheiro ============");
    Console.WriteLine("===============================================");
    Console.WriteLine();


}

string[] moznosti = { "kámen", "nůžky", "papír", "TEĎ!!!!!!"}; // z nejakyho duvodu i kdyz zadam TEĎ!!!!!!  tak to nepusti tak asi dobrý :P
Random random = new Random();

Console.WriteLine("Hrajeme kámen, nůžky, papír!");

// opakovani dokud nenapisu dobře K N P
string hracTah = "";
while (true)
{
    Console.Write("Zadej kámen, nůžky nebo papír: ");
    hracTah = Console.ReadLine().ToLower();

    if (Array.Exists(moznosti, s => s == hracTah))
    {
        break; // pokud dobry
    }
    else  // kdyz nedobrý 
    {
        Console.WriteLine("Neplatný tah! Musíš vybrat kámen, nůžky nebo papír.");
    }
}


foreach (string s in moznosti)
{
    Console.Write(s + " ");
    Thread.Sleep(1000); 
}
Console.WriteLine(); 

// PC
string pocitacTah = moznosti[random.Next(0, 3)];
Console.WriteLine($"Počítač zvolil: {pocitacTah}");

if (hracTah == pocitacTah)
{
    Console.WriteLine("Remíza!");
}
else if ((hracTah == "kámen" && pocitacTah == "nůžky") ||
         (hracTah == "nůžky" && pocitacTah == "papír") ||
         (hracTah == "papír" && pocitacTah == "kámen"))
{
    Console.WriteLine("Vyhrál jsi! 🎉");
}
else
{
    Console.WriteLine("Prohrál jsi 😢");
}

Console.WriteLine("Stiskni klávesu Enter pro ukončení");
Console.ReadLine();