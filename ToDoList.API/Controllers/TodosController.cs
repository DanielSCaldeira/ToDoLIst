using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ToDoList.Domain.Dtos;
using ToDoList.Interface;

namespace ToDoList.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodosController : AppBaseController
    {

        public TodosController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        [HttpGet]
        public IEnumerable<TodoDTO> Get()
        {
            return GetService<IListaRepository>().Get();
        }

        [HttpPost]
        public TodoDTO Post(TodoDTO registro)
        {
            return GetService<IListaRepository>().Post(registro);
        }  
        
        [HttpPut]
        public void Put(TodoDTO registro)
        {
            GetService<IListaRepository>().Put(registro);
        }


        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            GetService<IListaRepository>().Delete(id);
        }


    }
}
