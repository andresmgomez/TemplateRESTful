﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace TemplateRESTful.API.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]

    public abstract class RootController<T> : ControllerBase
    {
        private ILogger<T> _loggerInstance;
        protected ILogger<T> _logger => _loggerInstance ??= 
            HttpContext.RequestServices.GetService<ILogger<T>>();
    }
}