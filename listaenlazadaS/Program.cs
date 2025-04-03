
using System.Timers;
using listaenlazadaS;

Locomotora l =  new Locomotora();
l.AgregaFinal(2);
l.AgregaFinal(10);
l.AgregaFinal(20);
l.AgregaFinal(40);
l.AgregaFinal(30);

    Console.WriteLine(l.VerVagones());

if (l.ExisteValor(50) == true)
{
    Console.WriteLine("El valor si existe en la lista");
}
else
{
    Console.WriteLine("El valor no existe en la lista");
}
l.AgregaLEFinal();
l.DesplegarLista();