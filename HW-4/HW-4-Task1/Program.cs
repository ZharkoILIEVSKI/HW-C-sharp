
// Task 1

// Take one string from the input and print its last 5 characters.

Console.Write("Vnesi zborche: ");
string zbor = Convert.ToString(Console.ReadLine());

string formatiranoZborche = zbor.Substring((zbor.Length)-5,5);
Console.WriteLine(formatiranoZborche);