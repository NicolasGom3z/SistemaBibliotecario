using System;
namespace SistemaBibliotecario.App.Dominio.Entidades
{
    public class Ejemplar
    {
        public string ejem_scdd{get;set;}

        public Libro ejem_lib{get;set;}
        public Estado_ejemplar ejem_estEjem{get;set;}
    }
}