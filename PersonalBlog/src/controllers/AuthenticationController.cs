using PersonalBlog.src.dtos;
using PersonalBlog.src.services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace PersonalBlog.src.controllers
{
    [ApiController]
    [Route("api/Authentication")]
    [Produces("application/json")]
    public class AuthenticationController : ControllerBase
    {

        #region Attributes
        private readonly IAuthentication _services;
        #endregion


        #region Contructors
        private AuthenticationController (IAuthentication services)
        {
            _services = services;
        }
        #endregion


        #region Methods
        /// <summary>
        /// Get Authorization
        /// </summary>
        /// <param name="authentication"> AuthenticateDTO</param>
        /// <returns>ActionResult</returns>
        /// <remarks>
        /// Requisition example:
        ///
        ///     POST /api/Authentication
        ///     {
        ///        "email": "rodrigo@domain.com",
        ///        "senha": "134652"
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Return the created user</response>
        /// <response code="400">Requisition error</response>
        /// <response code="401">Invalid e-mail or password</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AuthorizationDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> AuthenticateAsync([FromBody] AuthenticationDTO authentication)
        {
            if (!ModelState.IsValid) return BadRequest();
            try
            {
                AuthorizationDTO authorization = await _services.GetAuthorizationAsync(authentication);
                return Ok(authorization);
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }
        #endregion
    }
}
