﻿using System.Text.Json;
using VA.Blazor.CleanArchitecture.Application.Interfaces.Services.Storage.Serialization;
using VA.Blazor.CleanArchitecture.Infrastructure.Services.Storage.StorageOptions;
using Microsoft.Extensions.Options;

namespace VA.Blazor.CleanArchitecture.Infrastructure.Services.Storage.Serialization
{
    internal class SystemTextJsonSerializer : IJsonSerializer
    {
        private readonly JsonSerializerOptions _options;

        public SystemTextJsonSerializer(IOptions<ServerStorageOptions> options)
        {
            _options = options.Value.JsonSerializerOptions;
        }

        public T Deserialize<T>(string data)
            => JsonSerializer.Deserialize<T>(data, _options);

        public string Serialize<T>(T data)
            => JsonSerializer.Serialize(data, _options);
    }
}