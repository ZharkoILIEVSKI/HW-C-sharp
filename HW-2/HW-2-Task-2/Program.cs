
Console.WriteLine("****SUM OF EVEN***");

int[] nizaOdIntegeri = new int [6];

Console.Write("Vnesete go prviot broj: "); 
int a = Convert.ToInt32(Console.ReadLine());
nizaOdIntegeri[0] = a;

Console.Write("Vnesete go vtoriot broj: "); 
int b = Convert.ToInt32(Console.ReadLine());
nizaOdIntegeri[1] = b;

Console.Write("Vnesete go tretiot broj: "); 
int c = Convert.ToInt32(Console.ReadLine());
nizaOdIntegeri[2] = c;

Console.Write("Vnesete go cetvrtiot broj: "); 
int d = Convert.ToInt32(Console.ReadLine());
nizaOdIntegeri[3] = d;

Console.Write("Vnesete go pettiot broj: "); 
int e = Convert.ToInt32(Console.ReadLine());
nizaOdIntegeri[4] = e;

Console.Write("Vnesete go shestiot broj: "); 
int f = Convert.ToInt32(Console.ReadLine());
nizaOdIntegeri[5] = f;

int sumaOdParniBroevi = 0;

for (int i = 0; i < nizaOdIntegeri.Length; i++)
{
    if (nizaOdIntegeri[i]%2 == 0)
    {
        sumaOdParniBroevi += nizaOdIntegeri[i]; 
    }
}
Console.WriteLine("*********************************************");
Console.WriteLine("Zbirot od parnite broevi vo nizata e: " + sumaOdParniBroevi);
Console.WriteLine("*********************************************");