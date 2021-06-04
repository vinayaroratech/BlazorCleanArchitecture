﻿using VA.Blazor.CleanArchitecture.Application.Interfaces.Services;
using VA.Blazor.CleanArchitecture.Application.Models.Chat;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Application.Interfaces.Chat;
using VA.Blazor.CleanArchitecture.Shared.Constants.Permission;

namespace VA.Blazor.CleanArchitecture.Server.Controllers.Communication
{
    [Authorize(Policy = Permissions.Communication.Chat)]
    [Route("api/[controller]")]
    [ApiController]
    public class ChatsController : ControllerBase
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IChatService _chatService;

        public ChatsController(ICurrentUserService currentUserService, IChatService chatService)
        {
            _currentUserService = currentUserService;
            _chatService = chatService;
        }

        //Get user wise chat history
        [HttpGet("{contactId}")]
        public async Task<IActionResult> GetChatHistoryAsync(string contactId)
        {
            return Ok(await _chatService.GetChatHistoryAsync(_currentUserService.UserId, contactId));
        }

        //get available users - sorted by date of last message if exists
        [HttpGet("users")]
        public async Task<IActionResult> GetChatUsersAsync()
        {
            return Ok(await _chatService.GetChatUsersAsync(_currentUserService.UserId));
        }

        //save chat message
        [HttpPost]
        public async Task<IActionResult> SaveMessageAsync(ChatHistory<IChatUser> message)
        {
            message.FromUserId = _currentUserService.UserId;
            message.ToUserId = message.ToUserId;
            message.CreatedDate = DateTime.Now;
            return Ok(await _chatService.SaveMessageAsync(message));
        }
    }
}