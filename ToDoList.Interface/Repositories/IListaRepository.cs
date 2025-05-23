﻿using System.Collections.Generic;
using ToDoList.Domain.Dtos;
using ToDoList.Domain.Entities;

namespace ToDoList.Interface
{
    public interface IListaRepository
    {
        /// <summary>
        /// Buscar lista de tarefas
        /// </summary>
        /// <returns></returns>
        List<TodoDTO> Get();

        /// <summary>
        /// Inserir tarefa
        /// </summary>
        /// <param name="registro">Registro da tarefa a ser inserida</param>
        TodoDTO Post(TodoDTO registro);

        /// <summary>
        /// Atualizar tarefa
        /// </summary>
        /// <param name="registro">Registro da tarefa a ser atualizada</param>
        void Put(TodoDTO registro);

        /// <summary>
        /// Excluir item da lista de tarefas
        /// </summary>
        /// <param name="id">Id do item da lista a ser excluido</param>
        void Delete(int id);


        /// <summary>
        /// Pesquisar item na lista de tarefas
        /// </summary>
        /// <param name="descricao">Texto para a consulta</param>
        /// <returns>Lista de itens de tarefas</returns>
        List<TodoItem> Search(string descricao);
    }
}
