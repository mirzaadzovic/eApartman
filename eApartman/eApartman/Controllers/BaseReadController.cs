using eApartman.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseReadController<T, TSearch> : ControllerBase where T:class where TSearch:class
    {
        protected readonly IReadService<T, TSearch> _service;
        public BaseReadController(IReadService<T, TSearch> service)
        {
            _service = service;
        }
        [HttpGet]
        public virtual IEnumerable<T> Get([FromQuery]TSearch search=null)
        {
            return _service.Get(search);
        }
        [HttpGet("{id}")]
        public virtual T GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
