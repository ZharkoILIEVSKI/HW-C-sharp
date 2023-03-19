// Task 2
// Take a sentence as input and print its words.

Console.Write("Vnesete recenica: ");
string razdelenaRecenica = Console.ReadLine();

string[] recenicaVoNiza = razdelenaRecenica.Split(" ");

foreach (string zborce in recenicaVoNiza)
{ 
   Console.WriteLine(zborce);
}