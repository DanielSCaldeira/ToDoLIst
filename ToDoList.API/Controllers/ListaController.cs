using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ToDoList.Domain.Dtos;
using ToDoList.Interface;

namespace ToDoList.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListaController : AppBaseController
    {

        public ListaController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }


        [HttpGet]
        public IEnumerable<ListaDTO> Get()
        {
            return GetService<IListaRepository>().Get();
        }

        [HttpPost]
        public string Post(ListaDTO registro)
        {
            GetService<IListaRepository>().Post(registro);
            return "Registro inserido com sucesso!";
        }  
        
        [HttpPut]
        public string Put(ListaDTO registro)
        {
            GetService<IListaRepository>().Put(registro);
            return "Registro alterado com sucesso!";
        }


        [HttpDelete]
        [Route("{id}")]
        public string Delete(int id)
        {
            GetService<IListaRepository>().Delete(id);
            return "Registro excluido com sucesso!";
        }


    }
}
