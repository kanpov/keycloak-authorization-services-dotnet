// <auto-generated/>
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Policies;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Profiles;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\realms\{realm}\client-policies
    /// </summary>
    public class ClientPoliciesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The policies property</summary>
        public Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Policies.PoliciesRequestBuilder Policies
        {
            get => new Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Policies.PoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The profiles property</summary>
        public Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Profiles.ProfilesRequestBuilder Profiles
        {
            get => new Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.Profiles.ProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.ClientPoliciesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ClientPoliciesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/client-policies", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies.ClientPoliciesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ClientPoliciesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/client-policies", rawUrl)
        {
        }
    }
}
