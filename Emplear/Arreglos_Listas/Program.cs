using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_Listas
{
  class Informacion
  {
    //  feature C#
    //
    public string Nombre { get; set; } = "Hola!!!";

    //  feature C# 6
    //
    public void Metodo() => Console.WriteLine("Informacion...");

  }
  class Program
  {
    static void Main(string[] args)
    {
      ProbarLista();
      PressAnyKey();
    }

    static void ProbarLista()
    {
      List<int> enteros = new List<int>();

      enteros.AddRange(Enumerable.Range(0, 10));
      enteros.AddRange(Enumerable.Range(0, 10));

      enteros.Insert(4, 1234);
      Console.WriteLine($"Capacidad = {enteros.Capacity}, Cuenta = {enteros.Count}");
      PrintLista(enteros);
      PressAnyKey();

      enteros.Remove(4);

      Console.Clear();
      Console.WriteLine($"Capacidad = {enteros.Capacity}, Cuenta = {enteros.Count}");
      PrintLista(enteros);
      PressAnyKey();

      enteros.RemoveAll(x => x % 2 == 1);

      Console.Clear();
      Console.WriteLine($"Capacidad = {enteros.Capacity}, Cuenta = {enteros.Count}");
      PrintLista(enteros);
    }

    static void PrintLista<T>(ICollection<T> lista)
    {
      int indice = 0;
      int padding = (int)Math.Ceiling(Math.Log10(lista.Count));
      string formato = $"{{0:D{padding}}} --> {{1}}";   //  feature de C# 6

      foreach (T item in lista)
        Console.WriteLine(formato, indice++, item);
    }

    static void PressAnyKey()
    {
      Console.WriteLine("\nPress Any Key");
      Console.ReadLine();
    } 
  }
}
