// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtScopeResource.Models
{
    /// <summary> Operation status message object. </summary>
    public partial class StatusMessage
    {
        /// <summary> Initializes a new instance of StatusMessage. </summary>
        internal StatusMessage()
        {
        }

        /// <summary> Initializes a new instance of StatusMessage. </summary>
        /// <param name="status"> Status of the deployment operation. </param>
        /// <param name="error"> The error reported by the operation. </param>
        internal StatusMessage(string status, ErrorResponse error)
        {
            Status = status;
            Error = error;
        }

        /// <summary> Status of the deployment operation. </summary>
        public string Status { get; }
        /// <summary> The error reported by the operation. </summary>
        public ErrorResponse Error { get; }
    }
}
