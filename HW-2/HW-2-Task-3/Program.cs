Console.WriteLine("");
Console.WriteLine("****STUDENT GROUP****");//Naslov
Console.WriteLine("");

string[] prvaGrupa = new string[] {"Mitre", "Stanislav", "Stojan", "Petrisimus", "Paraskeva"};

string[] vtoraGrupa = new string[] {"Bojan", "Damjan", "Stojan", "Ana", "Marija"};

Console.WriteLine("1. Grupa 1 ");
Console.WriteLine("2. Grupa 2 ");
Console.Write("Vnesete broj za da izberete prikaz na studentskite grupi: ");

string izbor = Console.ReadLine();

Console.WriteLine("");

switch (izbor)
{
    case "1":
    {
        for (int i = 0; i < prvaGrupa.Length; i++)
        {
            Console.WriteLine(prvaGrupa[i]);
        }
        break;
    }
    case "2":
    {
        for (int j = 0; j < vtoraGrupa.Length; j++)
        {
            Console.WriteLine(vtoraGrupa[j]);
        }
        break;
    }
    default: 
    Console.WriteLine("Pogresen izbor...Birajte povtorno");
    break;
}

Console.WriteLine("");