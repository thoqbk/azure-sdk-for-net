// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Identity properties of the workspace resource. </summary>
    internal partial class WorkspaceIdentity
    {
        /// <summary> Initializes a new instance of WorkspaceIdentity. </summary>
        internal WorkspaceIdentity()
        {
            Type = "SystemAssigned";
        }

        /// <summary> Initializes a new instance of WorkspaceIdentity. </summary>
        /// <param name="type"> The identity type. Currently the only supported type is &apos;SystemAssigned&apos;. </param>
        /// <param name="principalId"> The principal id of the identity. </param>
        /// <param name="tenantId"> The client tenant id of the identity. </param>
        internal WorkspaceIdentity(string type, string principalId, string tenantId)
        {
            Type = type;
            PrincipalId = principalId;
            TenantId = tenantId;
        }

        /// <summary> The identity type. Currently the only supported type is &apos;SystemAssigned&apos;. </summary>
        public string Type { get; set; }
        /// <summary> The principal id of the identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The client tenant id of the identity. </summary>
        public string TenantId { get; }
    }
}