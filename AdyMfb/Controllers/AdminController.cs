using EntityLayer.AdminDetails;
using EntityLayer.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdyMfb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminRepository _repository;

        public AdminController(IAdminRepository repository)
        {
            _repository = repository;
        }
            [HttpGet]
            public IActionResult GetAdmin()
            {
                var Admin = _repository.GetAllAdmin();
                return Ok(Admin);
            }
        
   }
}
