

int contP = 0, contI = 0;
Console.Write("Ingrese la cantidad de numero que desea: ");
int num = int.Parse(Console.ReadLine());
int[] numeros = new int[num];
Random ran = new Random();

for (int x = 0; x < num; x++)
{
    numeros[x] = ran.Next(50, 90);
    if (numeros[x] % 2 != 0)
    {
        contI++;
    }
    if (numeros[x] % 2 == 0)
    {
        contP++;
    }
}
Console.WriteLine("Quieres numeros pares o impares?");
string tipo = Console.ReadLine();

string all = string.Join(", ", numeros); 
Console.WriteLine($"Los numeros son {all}");


if (tipo == "impares")
{
    
    Console.WriteLine("La cantidad son de impares son " + contI);
}
else if (tipo == "pares")
{
    
    Console.WriteLine("La cantidad son de pares son " + contP);
}
