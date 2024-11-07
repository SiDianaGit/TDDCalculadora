using System.Threading.Tasks.Dataflow;
using AppCalculadora;


Calcular calc = new();



calc.Multiplicar(5,7);
calc.Dividir(50,5);
calc.Subtrair(4,7);
calc.Somar(1,3);

List<string> lista = calc.Listar();

foreach (var item in lista)
{
    Console.WriteLine(item);
}




