// ● Create 2 methods called Sum and Subtract
// ● Sum will accept two numbers as parameters and return a
// result from summing the two numbers
// ● Subtract will accept two numbers as parameters and return
// a result from subtracting the two numbers
// Multiply
// Divide
// ● Ask a person from the console to enter - or +
// ● Then ask the person to enter two numbers
// ● Call the corresponding method ( sum or subtract ) and
// return the result to the console

Console.WriteLine("");
Console.WriteLine("******THE BEST CALCULATOR EVER AND EVER*****");
Console.WriteLine("");

void Main()  // Glaven metod sto se izvrsuva pri startuvanje na kodot t.e posle ova pogore :)
{
    Console.WriteLine("Vnesete go znakot za soodvetnata operacija za presmetka so dva broja: ");
    Console.WriteLine("+ za sobiranje, - za odzemanje, * za mnozenje, - za delenje");
    char operacija = char.Parse(Console.ReadLine()); //Konverzija od string vo tip char



    Console.Write("Vnesete go prviot od dvata broja: "); //Vnesuvanje na prv broj
    double prvBroj = double.Parse(Console.ReadLine()); //Konverzija od string vo tip double

    Console.Write("Vnesete go vtoriot od dvata broja: "); //Vnesuvanje na vtor broj
    double vtorBroj = double.Parse(Console.ReadLine()); //Konverzija od string vo tip double
    
    switch (operacija)
    {
        case '+':
            double sob = Sum(prvBroj, vtorBroj);
            Prikaz(sob, "sobiranje");
            break;
        case '-':
            double odz = Substract(prvBroj, vtorBroj);
            Prikaz(odz, "odzemanje");
            break;
        case '*':
            double mno = Multiply(prvBroj, vtorBroj);
            Prikaz(mno, "mnozenje");
            break;
        case '/':
            double del = Divide(prvBroj, vtorBroj);
            Prikaz(del, "delenje");
            break;

        default: 
        Console.WriteLine("NE VNESOVTE SOODVETEN ZNAK...Probajte povtorno");
        break;
    }
}

double Sum(double a, double b)   //metod za sobiranje
{
    return a + b;
}

double Substract(double a, double b)   //metod za odzemanje
{
    return a - b;
}

double Multiply(double a, double b)   //metod za mnozenje
{
    return a * b;
}

double Divide(double a, double b)   //metod za odzemanje
{
    return a / b;
}

void Prikaz(double res, string tipNaOperacija)   //Metod za prikaz na rezultatot
{
    Console.WriteLine("*************************************************************");
    Console.WriteLine("Rezultatot od operacijata " + tipNaOperacija + " e: " + res);
    Console.WriteLine("*************************************************************");
    Console.WriteLine("");
}

Main();