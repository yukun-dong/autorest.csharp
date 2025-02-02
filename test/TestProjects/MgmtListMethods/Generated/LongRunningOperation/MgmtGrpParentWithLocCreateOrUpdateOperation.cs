// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using MgmtListMethods;

namespace MgmtListMethods.Models
{
    /// <summary> Create or update. </summary>
    public partial class MgmtGrpParentWithLocCreateOrUpdateOperation : Operation<MgmtGrpParentWithLoc>
    {
        private readonly OperationOrResponseInternals<MgmtGrpParentWithLoc> _operation;

        /// <summary> Initializes a new instance of MgmtGrpParentWithLocCreateOrUpdateOperation for mocking. </summary>
        protected MgmtGrpParentWithLocCreateOrUpdateOperation()
        {
        }

        internal MgmtGrpParentWithLocCreateOrUpdateOperation(ArmResource operationsBase, Response<MgmtGrpParentWithLocData> response)
        {
            _operation = new OperationOrResponseInternals<MgmtGrpParentWithLoc>(Response.FromValue(new MgmtGrpParentWithLoc(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override MgmtGrpParentWithLoc Value => _operation.Value;

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
        public override ValueTask<Response<MgmtGrpParentWithLoc>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<MgmtGrpParentWithLoc>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
