// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.StorageSync
{
    internal class RegisteredServerOperationSource : IOperationSource<RegisteredServerResource>
    {
        private readonly ArmClient _client;

        internal RegisteredServerOperationSource(ArmClient client)
        {
            _client = client;
        }

        RegisteredServerResource IOperationSource<RegisteredServerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RegisteredServerData.DeserializeRegisteredServerData(document.RootElement);
            return new RegisteredServerResource(_client, data);
        }

        async ValueTask<RegisteredServerResource> IOperationSource<RegisteredServerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RegisteredServerData.DeserializeRegisteredServerData(document.RootElement);
            return new RegisteredServerResource(_client, data);
        }
    }
}
