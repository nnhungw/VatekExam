﻿using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using IdentityService.ApiModels.ApiInputModels.Auth;
using IdentityService.ApiModels.ApiResponseModels;
using IdentityService.Commons.Communication;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IdentityService.Controllers
{
    [ApiController]
    [Route("auth")]
    [Produces("application/json")]
    public class AuthController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        [ProducesResponseType(typeof(ApiResponseModel<ConfirmationResponseModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Register([FromBody] AuthRegisterInputModel input)
        {
            return await _mediator.Send(ApiActionModel.CreateRequest(input));
        }

        [HttpPost("verify")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> VerifyAccount([FromBody] AuthVerifyInputModel input)
        {
            return await _mediator.Send(ApiActionModel.CreateRequest(input));
        }

        [HttpPost("login")]
        [ProducesResponseType(typeof(ApiResponseModel<UserLoginResponseModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Login([FromBody] AuthLoginInputModel input)
        {
            return await _mediator.Send(ApiActionModel.CreateRequest(input));
        }

        //[HttpPost("resend-confirmation")]
        //[Produces("application/json")]
        //[ProducesResponseType(typeof(ApiResponseModel<ConfirmationResponseModel>), (int)HttpStatusCode.OK)]
        //public async Task<IActionResult> ResendConfirmation([FromBody] ResendConfirmationInputModel)
        //{
        //    return await _mediator
        //}
    }
}

