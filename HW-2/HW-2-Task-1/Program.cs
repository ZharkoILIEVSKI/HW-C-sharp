Console.Write("Vnesi prv broj: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Vnesi vtor broj: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("Prviot broj sto go vnesovte e: " + x);//Prikaz 1
Console.WriteLine("Vtoriot broj sto go vnesovte e: " + y);

int z = x;//z dobiva vrednost na prv broj, x e ist, y ostanuva ist
x = y;//x ja zema vrednosta od vtoriot broj, y ostanuva ist
y = z;//y ja zema vrednosta od z koj ja imase zemeno od x

Console.WriteLine("");
Console.WriteLine("***PO ZAMENATA***");
Console.WriteLine("");

Console.WriteLine("Prviot broj sto go vnesovte e: " + x);//Prikaz 2
Console.WriteLine("Vtoriot broj sto go vnesovte e: " + y);
