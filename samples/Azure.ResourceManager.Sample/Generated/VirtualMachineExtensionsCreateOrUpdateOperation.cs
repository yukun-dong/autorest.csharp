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
    /// <summary> The operation to create or update the extension. </summary>
    public partial class VirtualMachineExtensionsCreateOrUpdateOperation : Operation<VirtualMachineExtension>, IOperationSource<VirtualMachineExtensionData>
    {
        private readonly OperationInternals<VirtualMachineExtensionData> _operation;

        private readonly ResourceOperationsBase _operationBase;

        /// <summary> Initializes a new instance of VirtualMachineExtensionsCreateOrUpdateOperation for mocking. </summary>
        protected VirtualMachineExtensionsCreateOrUpdateOperation()
        {
        }

        internal VirtualMachineExtensionsCreateOrUpdateOperation(ResourceOperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualMachineExtensionData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VirtualMachineExtensionsCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualMachineExtension Value => new VirtualMachineExtension(_operationBase, _operation.Value);

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
        public async override ValueTask<Response<VirtualMachineExtension>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => MapResponseType(await _operation.WaitForCompletionAsync(cancellationToken));

        /// <inheritdoc />
        public async override ValueTask<Response<VirtualMachineExtension>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => MapResponseType(await _operation.WaitForCompletionAsync(pollingInterval, cancellationToken));

        private Response<VirtualMachineExtension> MapResponseType(Response<VirtualMachineExtensionData> response) => Response.FromValue(new VirtualMachineExtension(_operationBase, response.Value), response.GetRawResponse());

        VirtualMachineExtensionData IOperationSource<VirtualMachineExtensionData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return VirtualMachineExtensionData.DeserializeVirtualMachineExtensionData(document.RootElement);
        }

        async ValueTask<VirtualMachineExtensionData> IOperationSource<VirtualMachineExtensionData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return VirtualMachineExtensionData.DeserializeVirtualMachineExtensionData(document.RootElement);
        }
    }
}