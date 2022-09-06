using System;

namespace EjerciciosPOO
{
    class AlbumFotos
    {
        protected int numeroDePaginas;

        public AlbumFotos()
        {
            this.numeroDePaginas = 16;
        }

        public AlbumFotos(int numeroDePaginas)
        {
            this.numeroDePaginas = numeroDePaginas;
        }
        public int NumeroDePaginas
        {
            get{ return numeroDePaginas; }
            set { numeroDePaginas = value; }
        }
    }
}
