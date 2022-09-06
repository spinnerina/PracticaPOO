using System;

namespace EjerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            AlbumFotos fotos = new AlbumFotos();
            AlbumFotos sobrecarga = new AlbumFotos(24);
            AlbumFotosGrande fotosGrandes = new AlbumFotosGrande();

            Console.WriteLine("La cantidad de paginas en un album de fotos predetermminado son: " + fotos.NumeroDePaginas);
            Console.WriteLine("La cantidad de paginas en un album de fotos de sobrecarga son: " + sobrecarga.NumeroDePaginas);
            Console.WriteLine("La cantidad de paginas en un album grande de fotos son: " + fotosGrandes.NumeroDePaginas);
        }
    }
}
