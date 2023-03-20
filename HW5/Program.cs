// Task 3

// Create an ATM application. A customer should be able to authenticate with    card number and pin and should be greeted with a message greeting them by full name. After that they can choose one of the following:

//     Balance checking - This should print out the current balance of money on their account
//     Cash withdrawal - This should try and withdraw cash from the users account and print a message. If it has enough it should print a success message that contains the money withdrawn and the balance of money after the withdrawal
//     Cash deposition - This should deposit cash on the account and give a message with the new balance of money on the account after the deposit.

// In order for the ATM app to work we need Customers. This ATM asks for the number ( string ) of the card and searches through the customers if a card like that exists. After that it asks for a pin. If the Pin matches that customer a welcome message is shown and the customer can now choose the options.
using HW_5;


Console.WriteLine("");
Console.WriteLine("****ATM application****"); //Naslov
Console.WriteLine("");


Customer firstCustomer;
firstCustomer.FirstName = "Zharko";
firstCustomer.LastName = "Ilievski";
firstCustomer.BalanceCheck();

Console.WriteLine(firstCustomer.FirstName +firstCustomer.LastName);