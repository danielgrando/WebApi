using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploWebApi.Models
{
    public class Cliente
    {

        public string Nome { get; set; }
        public int Id { get; set; }

        public Cliente(string nome, int id)
        {
            this.Nome = nome;
            this.Id = id;
        }

    }
}