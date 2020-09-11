using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TraderApi.ViewModels;

namespace TraderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserManager _userManager;
        private readonly IMapper _mapper;
        public UserController(IMapper mapper, IUserManager userManager)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        // GET: api/<UserController>
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<UserDetailViewModel>))]
        public async Task<IActionResult> GetAsync()
        {
            var users = await _userManager.GetUsersAsync();
            return Ok(_mapper.Map<List<UserDetailViewModel>>(users));
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(UserDetailViewModel))]
        public async Task<IActionResult> GetAsync(int id)
        {
            var user = await _userManager.GetUserByIdAsync(id);
            return Ok(_mapper.Map<UserDetailViewModel>(user));
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
