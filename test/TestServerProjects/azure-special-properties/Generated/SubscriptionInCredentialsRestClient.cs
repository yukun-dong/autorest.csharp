// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace azure_special_properties
{
    internal partial class SubscriptionInCredentialsRestClient
    {
        private string subscriptionId;
        private string host;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of SubscriptionInCredentialsRestClient. </summary>
        public SubscriptionInCredentialsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "http://localhost:3000", string apiVersion = "2015-07-01-preview")
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.subscriptionId = subscriptionId;
            this.host = host;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreatePostMethodGlobalValidRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/azurespecials/subscriptionId/method/string/none/path/global/1234-5678-9012-3456/", false);
            uri.AppendPath(subscriptionId, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PostMethodGlobalValidAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreatePostMethodGlobalValidRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostMethodGlobalValid(CancellationToken cancellationToken = default)
        {
            using var message = CreatePostMethodGlobalValidRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostMethodGlobalNullRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/azurespecials/subscriptionId/method/string/none/path/global/null/", false);
            uri.AppendPath(subscriptionId, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to null, and client-side validation should prevent you from making this call. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PostMethodGlobalNullAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreatePostMethodGlobalNullRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to null, and client-side validation should prevent you from making this call. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostMethodGlobalNull(CancellationToken cancellationToken = default)
        {
            using var message = CreatePostMethodGlobalNullRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostMethodGlobalNotProvidedValidRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/azurespecials/subscriptionId/method/string/none/path/globalNotProvided/1234-5678-9012-3456/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PostMethodGlobalNotProvidedValidAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreatePostMethodGlobalNotProvidedValidRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostMethodGlobalNotProvidedValid(CancellationToken cancellationToken = default)
        {
            using var message = CreatePostMethodGlobalNotProvidedValidRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostPathGlobalValidRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/azurespecials/subscriptionId/path/string/none/path/global/1234-5678-9012-3456/", false);
            uri.AppendPath(subscriptionId, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PostPathGlobalValidAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreatePostPathGlobalValidRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostPathGlobalValid(CancellationToken cancellationToken = default)
        {
            using var message = CreatePostPathGlobalValidRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostSwaggerGlobalValidRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/azurespecials/subscriptionId/swagger/string/none/path/global/1234-5678-9012-3456/", false);
            uri.AppendPath(subscriptionId, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PostSwaggerGlobalValidAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreatePostSwaggerGlobalValidRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostSwaggerGlobalValid(CancellationToken cancellationToken = default)
        {
            using var message = CreatePostSwaggerGlobalValidRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
