﻿using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using PCStore.Web.Core.Abstractions.Users;
using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;
using PCStore.Web.Core.EntitiesDTO.Update;

namespace PCStore.Web.Host.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsersController(IUsersService userService) : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        /// <response code="404">Not Found</response>
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<UsersEntityDTO>> GetUser(Guid id)
        {
            var user = await userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        [HttpGet]
        public async Task<ActionResult<UsersEntityDTO>> GetAllUsers()
        {
            var users = await userService.GetAllUsersAsync();
            return Ok(users);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        [HttpPost]
        public async Task<ActionResult<UsersEntityDTO>> CreateUser([FromBody] CreateUsersEntity createUser)
        {
            var user = await userService.CreateUserAsync(createUser);
            return Ok(user);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        public async Task<ActionResult<UsersEntityDTO>> UpdateUser([FromBody] UpdateUsersEntity updateUser)
        {
            var user = await userService.GetUserByIdAsync(updateUser.Id);
            if (user == null)
            {
                return NotFound();
            }
            var updatableUser = await userService.UpdateUserAsync(updateUser);
            return Ok(updatableUser);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Ok</response>
        /// <response code="404">Not Found</response>
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<bool>> DeleteUser(Guid id)
        {
            var isUserDeleted = await userService.DeleteUserAsync(id);
            if (!isUserDeleted)
            {
                return NotFound();
            }
            return Ok(isUserDeleted);
        }
    }
}
