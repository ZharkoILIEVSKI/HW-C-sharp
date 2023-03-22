
namespace HW5;
public class Customer
{
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string CardNumber{get;set;}
    public string PIN{get;set;}
    public double Balance{get;set;}
    public double CashIn{get; set;}
    public double CashOut{get;set;}

    public Customer()
    {
        
    }

    public void WelcomeGreeting(/*string firstName, string lastName*/)
    {
        Console.WriteLine("*** Dobro ni dojdovte i povelete "+ FirstName + " " + LastName + " ***");
    }

    public void BalanceCheck()
    {
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("Momentalnata sostojba na vasata smetka e: EUR " + Balance);
        Console.WriteLine("---------------------------------------------------------------");
    }

    public void CashDeposition()
    {
        Balance = Balance + CashIn;
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("Sostojbata na vasata smetka po vnesuvanje na novi sredstva e: EUR " + Balance);
        Console.WriteLine("--------------------------------------------------------------------------");
    }
    public void CashWithdrawal()
    {

        double novaBalance = Balance - CashOut;
        if(CashOut <= Balance)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Podignavte sredstva vo visina od: EUR " + CashOut);
            Console.WriteLine("Novata sostojba na vasata smetka po podginuvanje na sredstvata e: EUR " + novaBalance);
            Console.WriteLine("---------------------------------------------------------------");
        }
        else
        {
            Console.WriteLine("Sostojbata na vasata smetka e: EUR " + Balance + ". Ja nemate baranata visina na sredstva od: EUR " + CashOut + " na vasata smetka");
        }       
    }
}
