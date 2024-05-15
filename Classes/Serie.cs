
using System;
using Dio.Serie;

namespace Dio.Serie
{
    public class Serie : EntidadeBase
    {
       //Atributos
       private Categoria Categoria {get;set;}
       private Genero Genero {get; set;}
       private string Titulo {get; set;}
       private string Descricao {get; set;}
       private int Ano {get; set;}

       private bool Excluido {get;set;}

       //Metodos
       
        public Serie(int id, Categoria categoria, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Categoria = categoria;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Categoria: " + this.Categoria + Environment.NewLine;
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano;            
            return retorno;              
        }

        public string retornaTituloSerie()
        {
            return this.Titulo;
        }

        public int retornaIdSerie()
        {
            return this.Id;
        }

        public bool retornaExcluidoSerie()
        {
            return this.Excluido;
        }

        public void ExcluiSerie()
        {
            this.Excluido = true;
        }

    }
}