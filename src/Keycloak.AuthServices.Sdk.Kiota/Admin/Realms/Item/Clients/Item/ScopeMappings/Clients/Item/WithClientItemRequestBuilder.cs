// <auto-generated/>
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.ScopeMappings.Clients.Item.Available;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.ScopeMappings.Clients.Item.Composite;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.ScopeMappings.Clients.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\realms\{realm}\clients\{client-uuid}\scope-mappings\clients\{client}
    /// </summary>
    public class WithClientItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The available property</summary>
        public Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.ScopeMappings.Clients.Item.Available.AvailableRequestBuilder Available
        {
            get => new Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.ScopeMappings.Clients.Item.Available.AvailableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The composite property</summary>
        public Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.ScopeMappings.Clients.Item.Composite.CompositeRequestBuilder Composite
        {
            get => new Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.ScopeMappings.Clients.Item.Composite.CompositeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.ScopeMappings.Clients.Item.WithClientItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithClientItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/clients/{client%2Duuid}/scope-mappings/clients/{client}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.ScopeMappings.Clients.Item.WithClientItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithClientItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/clients/{client%2Duuid}/scope-mappings/clients/{client}", rawUrl)
        {
        }
        /// <summary>
        /// Remove client-level roles from the client&apos;s scope.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(List<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RoleRepresentation> body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(List<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RoleRepresentation> body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the roles associated with a client&apos;s scope Returns roles for the client.
        /// </summary>
        /// <returns>A List&lt;Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RoleRepresentation&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RoleRepresentation>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RoleRepresentation>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RoleRepresentation>(requestInfo, Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RoleRepresentation.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Add client-level roles to the client&apos;s scope
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(List<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RoleRepresentation> body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(List<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RoleRepresentation> body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Remove client-level roles from the client&apos;s scope.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(List<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RoleRepresentation> body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(List<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RoleRepresentation> body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Get the roles associated with a client&apos;s scope Returns roles for the client.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Add client-level roles to the client&apos;s scope
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(List<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RoleRepresentation> body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(List<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.RoleRepresentation> body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.ScopeMappings.Clients.Item.WithClientItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.ScopeMappings.Clients.Item.WithClientItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.ScopeMappings.Clients.Item.WithClientItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
