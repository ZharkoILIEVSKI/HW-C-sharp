// Task 3
// Create a function that takes a number as input. 
// This method should return the sum of the digits in the number.


int Main()
{

    Console.Write("Vnesete povekjecifren broj: "); //Vnesuvanje broj
    string povekjecifrenBroj = Convert.ToString(Console.ReadLine()); //Konvertiranje vo STRING type za sekoj sluchaj:)

    char[] brojVoNiza = povekjecifrenBroj.ToCharArray(); //Pretvoranje vo niza od CHAR type elementi

    int sum = 0;
    
    foreach (char cifra in brojVoNiza)   //Iteracija niz CHAR nizata za pravenje na zbir
    {
        Console.WriteLine(cifra);
        int cifraVoInt = Convert.ToInt32(cifra);
        sum += (cifraVoInt-48); //Poradi ASCII kodiranje na CHAR
        
    }
    return sum;
}

int rezultat = Main(); //Povikuvanje na metod
Console.WriteLine(rezultat); //Prikaz na rezultatot