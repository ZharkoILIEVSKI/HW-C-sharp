// Task 3

// Create an ATM application. A customer should be able to authenticate with    card number and pin and should be greeted with a message greeting them by full name. After that they can choose one of the following:

//     Balance checking - This should print out the current balance of money on their account
//     Cash withdrawal - This should try and withdraw cash from the users account and print a message. If it has enough it should print a success message that contains the money withdrawn and the balance of money after the withdrawal
//     Cash deposition - This should deposit cash on the account and give a message with the new balance of money on the account after the deposit.

// In order for the ATM app to work we need Customers. This ATM asks for the number ( string ) of the card and searches through the customers if a card like that exists. After that it asks for a pin. If the Pin matches that customer a welcome message is shown and the customer can now choose the options.

using HW5;

Console.WriteLine("");
Console.WriteLine("****ATM application****"); //Naslov
Console.WriteLine("");


Customer firstCustomer = new Customer();

firstCustomer.FirstName = "Zharko";//setiranje Ime
firstCustomer.LastName = "Ilievski";//setiranje Prezime
firstCustomer.PIN = "1234";//setiranje PIN
firstCustomer.CardNumber = "123 456 789 876";//setiranje broj na kartica
firstCustomer.Balance = 400.00;//setiranje na suma na pari na smetkata

void Main()
{
    Console.WriteLine("Dobar den, Ve molime vnesete PIN: ");//Poceten ekran
    string pinNaKorisnik = Console.ReadLine();
    if (pinNaKorisnik == firstCustomer.PIN)
    {
        firstCustomer.WelcomeGreeting(); //Pozdrav od ATM masinata do korisnikot
        Console.WriteLine(""); 
        Console.WriteLine("Ve molime izberete usluga: ");//Izbor na usluga
        Console.WriteLine("");
        Console.WriteLine("1. Proverka na sostojba na smetka "); //opcii
        Console.WriteLine("2. Vnesuvanje na paricni sredstva ");//opcii
        Console.WriteLine("3. Podignuvanje na paricni sredstva ");//opcii
        Console.WriteLine("");
        Console.Write("Vasiot izbor na usluga e so reden broj: ");//opcii
        int izbor = int.Parse(Console.ReadLine());

        switch (izbor)
        {
            case 1:
                firstCustomer.BalanceCheck();//Ispis na suma od smetka
                break;
            case 2:
                Console.WriteLine("Suma na pari koja ja vnesuvate: ");
                firstCustomer.CashIn = double.Parse(Console.ReadLine());//Stavanje paricki na smetka
                firstCustomer.CashDeposition(); //Prikaz kolkava e smetkata po stavanje na pari
                break;
            case 3:
                Console.WriteLine("Suma na pari koja ja podigate od smetka: ");
                firstCustomer.CashOut = double.Parse(Console.ReadLine());//Zemanje paricki od smetka
                firstCustomer.CashWithdrawal();//Prikaz kolkava e smetkata po zemanje na pari
                break;
            default:
                Console.WriteLine("*** !!! Vnesovte NEPOSTOECKA opcija. Probajte povtorno");
                break;
        }
    }
    else
    {
        Console.WriteLine("Pogresen PIN, probajte povtorno.");
    }
    Console.WriteLine("");
}

Main(); //Start na aplikacijata