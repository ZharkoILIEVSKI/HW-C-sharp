
// See https://aka.ms/new-console-template for more information

Console.WriteLine();
Console.WriteLine("***THE BEST OF THE CALCULATORS ***");
Console.WriteLine();

//Vnesuvanje na prviot broj
Console.Write("Vnesi eden broj: ");
double x = Convert.ToDouble(Console.ReadLine());

//Vnesuvanje na vtoriot broj
Console.Write("Vnesi drug broj: ");
double y = Convert.ToDouble(Console.ReadLine());

//Biranje na operacija
Console.WriteLine();
Console.WriteLine("Odberete go brojot pred operacijata sto sakate da ja napravite so broevite "+ x + " i " + y +" : ");

Console.WriteLine();
Console.WriteLine("1. SOBIRANJE     2. ODZEMANJE");
Console.WriteLine("3. MNOZENJE      4. DELENJE");

//Vnesuvanje izbor
Console.WriteLine();
Console.Write("Vnesete go vasiot izbor: ");

string z = Console.ReadLine();

Console.WriteLine();

//Izvrsuvanje na kod vo odnos na izborot pogore
if (z == "1")
{
    double sobiranje = x + y;
    Console.WriteLine("**************************************************************");
    Console.WriteLine("Operacijata SOBIRANJE go dade rezultatot: " + sobiranje);
}

if (z == "2")
{
    double odzemanje = x - y;
    Console.WriteLine("**************************************************************");
    Console.WriteLine("Operacijata ODZEMANJE go dade rezultatot: " + odzemanje);
}

if (z =="3")
{
    double mnozenje = x * y;
    Console.WriteLine("**************************************************************");
    Console.WriteLine("Operacijata MNOZENJE go dade rezultatot: " + mnozenje);
}
if (z =="4")
{
    double delenje = x / y;
    Console.WriteLine("**************************************************************");
    Console.WriteLine("Operacijata DELENJE go dade rezultatot: " + delenje);
}

//Blagodarnost za korisnikot
Console.WriteLine("**************************************************************");
Console.WriteLine("Vi blagodarime na koristenjeto!");
Console.WriteLine("");