﻿using VA.Blazor.CleanArchitecture.Application.Models.Chat;
using VA.Blazor.CleanArchitecture.Shared.Constants.Application;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Application.Interfaces.Chat;

namespace VA.Blazor.CleanArchitecture.Server.Hubs
{
    public class SignalRHub : Hub
    {
        public async Task OnConnectAsync(string userId)
        {
            await Clients.All.SendAsync(ApplicationConstants.SignalR.ConnectUser, userId);
        }

        public async Task OnDisconnectAsync(string userId)
        {
            await Clients.All.SendAsync(ApplicationConstants.SignalR.DisconnectUser, userId);
        }

        public async Task SendMessageAsync(ChatHistory<IChatUser> chatHistory, string userName)
        {
            await Clients.All.SendAsync(ApplicationConstants.SignalR.ReceiveMessage, chatHistory, userName);
        }

        public async Task ChatNotificationAsync(string message, string receiverUserId, string senderUserId)
        {
            await Clients.All.SendAsync(ApplicationConstants.SignalR.ReceiveChatNotification, message, receiverUserId, senderUserId);
        }

        public async Task UpdateDashboardAsync()
        {
            await Clients.All.SendAsync(ApplicationConstants.SignalR.ReceiveUpdateDashboard);
        }

        public async Task RegenerateTokensAsync()
        {
            await Clients.All.SendAsync(ApplicationConstants.SignalR.ReceiveRegenerateTokens);
        }
    }
}