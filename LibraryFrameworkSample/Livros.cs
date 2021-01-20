using System;
using Devmedia.Estudo.LibraryFrameworkSample.Library;

namespace Devmedia.Estudo.LibraryFrameworkSample
{
    public class Livros
    {
        string titulo;
        string autor;
        int anoPublicacao;

        public string Titulo
        {
            get { return titulo; }
            set{ titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int AnoPublicacao
        {
            get { return anoPublicacao; }
            set { anoPublicacao = value; }
        }

        Biblioteca _biblioteca;

        public Biblioteca _Biblioteca
        {
            get { return _biblioteca; }
            set { _biblioteca = value; }
        }

        
    }
}
