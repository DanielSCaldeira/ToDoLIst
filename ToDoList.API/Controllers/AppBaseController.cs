﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ToDoList.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppBaseController : ControllerBase
    {
        protected readonly IServiceProvider ServiceProvider;
        protected T GetService<T>()
        {
            return ServiceProvider.GetService<T>();
        }
        public AppBaseController(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

    }
}
