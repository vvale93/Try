<Query Kind="Statements" />


int numero = int.MaxValue;
int digito, suma;

suma = 0;

while (numero != 0)
{
    digito = numero % 10;
    numero = numero / 10;
    Console.WriteLine(digito);
    suma += digito;
}
Console.WriteLine(suma);

