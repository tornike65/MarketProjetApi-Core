using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MarketProj.Models.DTOs.InputDTOs;
using MarketProj.Models.DTOs.OutDTOs;
using MarketProj.Models.Entities;
using MarketProj.Services.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MarketProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ITemporaryUserService _temporaryUserService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper, ITemporaryUserService temporaryUserService)
        {
            _userService = userService;
            _mapper = mapper;
            _temporaryUserService = temporaryUserService;
        }


        [HttpGet("/login-temporary")]
        public async Task<ActionResult<UserOutDTOs>> LoginTemp(string username)
        {

            var user= await _temporaryUserService.Login(username, HttpContext.Connection.RemoteIpAddress.ToString());
            if (user == null)
                return Forbid();

            var userOutDto = _mapper.Map<UserOutDTOs>(user);

            return Ok(userOutDto);
        }

        [HttpPost("/login")]
        public async Task<ActionResult<UserOutDTOs>> Login(UserBasicInfoInputDTO userBasicInfo)
        {
            var user = await _userService.LoginAsync(userBasicInfo.Username.ToLower(), userBasicInfo.Password);
            if (user == null)
                return Forbid();

            var userOutDto = _mapper.Map<UserOutDTOs>(user);

            return Ok(userOutDto);
        }

        [HttpPost("/registration")]
        public async Task<ActionResult<UserOutDTOs>> Registration(UserInputDTO userInputDTO)
        {
            userInputDTO.Username = userInputDTO.Username.ToLower();
            var user = _mapper.Map<User>(userInputDTO);

            var isRegistration = await _userService.RegistrationAsync(user);

            if (isRegistration)
            {
                var userOutDto = _mapper.Map<UserOutDTOs>(await _userService.LoginAsync(user.Username, user.Password));
                return Ok(userOutDto);
            }

            return BadRequest();
        }



    }
}