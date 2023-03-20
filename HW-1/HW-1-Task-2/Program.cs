// See https://aka.ms/new-console-template for more information
Console.WriteLine("");

//Vnesuvanje na prviot broj
Console.Write("Vnesi eden broj: ");
double x = Convert.ToDouble(Console.ReadLine());

//Vnesuvanje na vtoriot broj
Console.Write("Vnesi drug broj: ");
double y = Convert.ToDouble(Console.ReadLine());

//Vnesuvanje na tret broj
Console.Write("Vnesi tret broj: ");
double z = Convert.ToDouble(Console.ReadLine());

//Vnesuvanje na cetvrt broj
Console.Write("Vnesi cetvrt broj: ");
double w = Convert.ToDouble(Console.ReadLine());

//Presmetka na PROSEK od broevite
double prosek = (x + y + z + w)/4;
Console.WriteLine("****************************************************");
Console.WriteLine("Prosekot od broevite " + x + " " +  y + " " + z + " " + w + " e: " + prosek);
Console.WriteLine("****************************************************");