using ExemploWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ExemploWebApi.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

    
        // GET api/<controller>
        public List<Cliente> Get()
        {
            return clientes;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] Cliente cliente)
        {
            //public void Post([FromBody] List<Cliente> clientes)
            if (!string.IsNullOrEmpty(cliente.Nome)) 
               clientes.Add(new Cliente(nome: cliente.Nome, id: cliente.Id));

        }
        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        { 
        }

        // DELETE api/<controller>/5
        public void Delete(string nome)
        {

            clientes.RemoveAt(clientes.IndexOf(clientes.First(cliente => cliente.Nome.Equals(nome))));
        }
    }
}