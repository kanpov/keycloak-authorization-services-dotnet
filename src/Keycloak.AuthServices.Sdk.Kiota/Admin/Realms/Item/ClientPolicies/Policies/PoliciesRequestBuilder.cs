// <auto-generated/>
using Keycloak.AuthServices.Sdk.Kiota.Admin.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Policies
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\realms\{realm}\client-policies\policies
    /// </summary>
    public class PoliciesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Policies.PoliciesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PoliciesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/client-policies/policies{?include%2Dglobal%2Dpolicies*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Policies.PoliciesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PoliciesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/client-policies/policies{?include%2Dglobal%2Dpolicies*}", rawUrl)
        {
        }
        /// <returns>A <see cref="Keycloak.AuthServices.Sdk.Kiota.Admin.Models.ClientPoliciesRepresentation"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.ClientPoliciesRepresentation?> GetAsync(Action<RequestConfiguration<Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Policies.PoliciesRequestBuilder.PoliciesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.ClientPoliciesRepresentation> GetAsync(Action<RequestConfiguration<Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Policies.PoliciesRequestBuilder.PoliciesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.ClientPoliciesRepresentation>(requestInfo, Keycloak.AuthServices.Sdk.Kiota.Admin.Models.ClientPoliciesRepresentation.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PutAsync(Keycloak.AuthServices.Sdk.Kiota.Admin.Models.ClientPoliciesRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> PutAsync(Keycloak.AuthServices.Sdk.Kiota.Admin.Models.ClientPoliciesRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Policies.PoliciesRequestBuilder.PoliciesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Policies.PoliciesRequestBuilder.PoliciesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Keycloak.AuthServices.Sdk.Kiota.Admin.Models.ClientPoliciesRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Keycloak.AuthServices.Sdk.Kiota.Admin.Models.ClientPoliciesRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Policies.PoliciesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Policies.PoliciesRequestBuilder WithUrl(string rawUrl)
        {
            return new Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Policies.PoliciesRequestBuilder(rawUrl, RequestAdapter);
        }
        #pragma warning disable CS1591
        public class PoliciesRequestBuilderGetQueryParameters 
        #pragma warning restore CS1591
        {
            [QueryParameter("include%2Dglobal%2Dpolicies")]
            public bool? IncludeGlobalPolicies { get; set; }
        }
    }
}
