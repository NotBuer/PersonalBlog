using PersonalBlog.src.dtos;
using PersonalBlog.src.services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;

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
        /// <param name="authenticationDTO"> AuthenticateDTO</param>
        /// <returns>ActionResult</returns>
        /// <remarks>
        /// Exemplo de requisição:
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
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AuthenticateDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Authenticate([FromBody] AuthenticateDTO authenticationDTO)
        {
            if (!ModelState.IsValid) return BadRequest();
            try
            {
                var authorization = _services.GetAuthorizationAsync(authenticationDTO);
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
