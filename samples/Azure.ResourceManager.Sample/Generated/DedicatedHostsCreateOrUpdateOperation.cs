// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sample
{
    /// <summary> Create or update a dedicated host . </summary>
    public partial class DedicatedHostsCreateOrUpdateOperation : Operation<DedicatedHost>, IOperationSource<DedicatedHostData>
    {
        private readonly OperationInternals<DedicatedHostData> _operation;

        private readonly ResourceOperationsBase _operationBase;

        /// <summary> Initializes a new instance of DedicatedHostsCreateOrUpdateOperation for mocking. </summary>
        protected DedicatedHostsCreateOrUpdateOperation()
        {
        }

        internal DedicatedHostsCreateOrUpdateOperation(ResourceOperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DedicatedHostData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DedicatedHostsCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DedicatedHost Value => new DedicatedHost(_operationBase, _operation.Value);

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public async override ValueTask<Response<DedicatedHost>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => MapResponseType(await _operation.WaitForCompletionAsync(cancellationToken));

        /// <inheritdoc />
        public async override ValueTask<Response<DedicatedHost>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => MapResponseType(await _operation.WaitForCompletionAsync(pollingInterval, cancellationToken));

        private Response<DedicatedHost> MapResponseType(Response<DedicatedHostData> response) => Response.FromValue(new DedicatedHost(_operationBase, response.Value), response.GetRawResponse());

        DedicatedHostData IOperationSource<DedicatedHostData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return DedicatedHostData.DeserializeDedicatedHostData(document.RootElement);
        }

        async ValueTask<DedicatedHostData> IOperationSource<DedicatedHostData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return DedicatedHostData.DeserializeDedicatedHostData(document.RootElement);
        }
    }
}