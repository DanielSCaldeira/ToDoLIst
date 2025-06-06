﻿using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.Domain.Dtos;
using ToDoList.Domain.Entities;
using ToDoList.Interface;

namespace ToDoList.Repository
{
    public class ListaRepository : BaseRepository, IListaRepository
    {
        public ListaRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Buscar lista de tarefas
        /// </summary>
        /// <returns></returns>
        public List<TodoDTO> Get()
        {
            try
            {
                var registros = DbContext.Listas.OrderBy(x => x.Id).ToList();

                return registros
                    .Select(x => new TodoDTO()
                    {
                        Done = x.Done,
                        CriadoEm = x.CriadoEm,
                        Todo = x.Todo,
                        Id = x.Id
                    }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Inserir tarefa
        /// </summary>
        /// <param name="registro">Registro da tarefa a ser inserida</param>
        public TodoDTO Post(TodoDTO registro)
        {
            try
            {
                if (registro.Id > 0)
                {
                    throw new Exception("Registo não pode conter ID preenchido!");
                }

                var resultado = new TodoItem()
                {
                    Done = registro.Done,
                    CriadoEm = DateTime.Now,
                    Todo = registro.Todo
                };
                DbContext.Listas.Add(resultado);
                DbContext.SaveChanges();

                return new TodoDTO()
                {
                    CriadoEm = resultado.CriadoEm,
                    Done = resultado.Done,
                    Id = resultado.Id,
                    Todo = resultado.Todo
                };

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Atualizar tarefa
        /// </summary>
        /// <param name="registro">Registro da tarefa a ser atualizada</param>
        public void Put(TodoDTO registro)
        {
            try
            {
                var resultado = DbContext.Listas.Find(registro.Id);

                if (resultado == null)
                {
                    throw new Exception("Registo não existe na base de dados!");
                }

                resultado.Done = registro.Done;
                resultado.CriadoEm = DateTime.Now;
                resultado.Todo = registro.Todo;

                DbContext.Listas.Update(resultado);
                DbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Excluir item da lista de tarefas
        /// </summary>
        /// <param name="id">Id do item da lista a ser excluido</param>
        public void Delete(int id)
        {
            try
            {
                var resultado = DbContext.Listas.Find(id);
                if (resultado == null)
                {
                    throw new Exception("Registo não existe na base de dados!");
                }

                DbContext.Remove(resultado);
                DbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Pesquisar item na lista de tarefas
        /// </summary>
        /// <param name="descricao">Texto para a consulta</param>
        /// <returns>Lista de itens de tarefas</returns>
        public List<TodoItem> Search(string descricao)
        {
            try
            {
                return DbContext.Listas.Where(x => x.Todo.ToUpper() == descricao.ToUpper()).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
