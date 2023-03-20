namespace HW_5;
public class Customer
{
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string CardNumber{get;set;}
    public string PIN{get;set;}
    public double Balance{get;set;}

    public void WelcomeGreeting(string FirstName, string LastName)
    {
        Console.WriteLine("*** Welcome "+ FirstName + " " + LastName + " ***");
    }

    public void BalanceCheck(double Balance)
    {
        Console.WriteLine("The balance is: EUR" + Balance);
    }

    public void CashDeposition(double Balance)
    {
        Console.WriteLine("The balance is: EUR" + Balance);
    }
}
