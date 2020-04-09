// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace header
{
    internal class HeaderResponseDateHeaders
    {
        private readonly Response _response;
        public HeaderResponseDateHeaders(Response response)
        {
            _response = response;
        }
        public DateTimeOffset? Value => _response.Headers.TryGetValue("value", out DateTimeOffset? value) ? value : null;
    }
}