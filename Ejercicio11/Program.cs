int[] numeros = new int[1];
Random n = new Random();
int contP = 0, contI = 0;
Console.Write("Ingrese la cantidad de numero que desea: ");
int num = int.Parse(Console.ReadLine());

for (int x = 0; x < num; x++)
{
    numeros[x] = n.Next(50, 90);
}
Console.WriteLine("Quieres numeros pares o impares?");
string tipo = Console.ReadLine();

if (numeros[1] % 2 == 0)
{
    contP++;
}
else if (numeros[1] % 2 != 0)
{
    contI++;
}

if (tipo == "impar")
{
    Console.WriteLine(contI);
}
else if (tipo == "par")
{
    Console.WriteLine(contP);
}
