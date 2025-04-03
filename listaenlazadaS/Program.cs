
using listaenlazadaS;

Locomotora l =  new Locomotora();
l.AgregaFinal(2);
l.AgregaFinal(10);
l.AgregaFinal(20);
l.EliminarUltimo();
Console.WriteLine(l.VerVagones());