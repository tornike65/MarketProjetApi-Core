using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MarketProj.DomainEvents;
using MarketProj.Models.Constants;
using MarketProj.Models.DTOs.InputDTOs;
using MarketProj.Services.Services.Abstract;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatMessageService _chatMessageService;
        private readonly IMediator _mediator;
        public ChatController(IChatMessageService chatMessageService, IMediator mediator)
        {
            _chatMessageService = chatMessageService;
            _mediator = mediator;
        }

        [Authorize(Roles = "Customer,TempCustomer,User")]
        [HttpPost("sent-message")]
        public async Task<IActionResult> SendMessage(ChatMessageInputDTO chatMessageInput)
        {
            var userInfo = User.Claims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier);
            Guid.TryParse(User.Claims.FirstOrDefault(o => o.Type == ClaimTypes.Name)?.Value, out Guid userId);

            if (userId == default)
            {
                return BadRequest();
            }

            await _chatMessageService.SentMessageAsync(chatMessageInput.ReciveUserId, userId, chatMessageInput.Message);
            await _mediator.Publish(new MessageSentDomainEvent(chatMessageInput.ReciveUserId, userId, chatMessageInput.Message, DateTime.Now));

            return Ok();
        }
    }
}