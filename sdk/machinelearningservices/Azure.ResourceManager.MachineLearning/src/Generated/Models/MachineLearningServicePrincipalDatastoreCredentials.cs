// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Service Principal datastore credentials configuration. </summary>
    public partial class MachineLearningServicePrincipalDatastoreCredentials : MachineLearningDatastoreCredentials
    {
        /// <summary> Initializes a new instance of MachineLearningServicePrincipalDatastoreCredentials. </summary>
        /// <param name="clientId"> [Required] Service principal client ID. </param>
        /// <param name="secrets"> [Required] Service principal secrets. </param>
        /// <param name="tenantId"> [Required] ID of the tenant to which the service principal belongs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secrets"/> is null. </exception>
        public MachineLearningServicePrincipalDatastoreCredentials(Guid clientId, MachineLearningServicePrincipalDatastoreSecrets secrets, Guid tenantId)
        {
            Argument.AssertNotNull(secrets, nameof(secrets));

            ClientId = clientId;
            Secrets = secrets;
            TenantId = tenantId;
            CredentialsType = CredentialsType.ServicePrincipal;
        }

        /// <summary> Initializes a new instance of MachineLearningServicePrincipalDatastoreCredentials. </summary>
        /// <param name="credentialsType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="authorityUri"> Authority URL used for authentication. </param>
        /// <param name="clientId"> [Required] Service principal client ID. </param>
        /// <param name="resourceUri"> Resource the service principal has access to. </param>
        /// <param name="secrets"> [Required] Service principal secrets. </param>
        /// <param name="tenantId"> [Required] ID of the tenant to which the service principal belongs. </param>
        internal MachineLearningServicePrincipalDatastoreCredentials(CredentialsType credentialsType, Uri authorityUri, Guid clientId, Uri resourceUri, MachineLearningServicePrincipalDatastoreSecrets secrets, Guid tenantId) : base(credentialsType)
        {
            AuthorityUri = authorityUri;
            ClientId = clientId;
            ResourceUri = resourceUri;
            Secrets = secrets;
            TenantId = tenantId;
            CredentialsType = credentialsType;
        }

        /// <summary> Authority URL used for authentication. </summary>
        public Uri AuthorityUri { get; set; }
        /// <summary> [Required] Service principal client ID. </summary>
        public Guid ClientId { get; set; }
        /// <summary> Resource the service principal has access to. </summary>
        public Uri ResourceUri { get; set; }
        /// <summary> [Required] Service principal secrets. </summary>
        public MachineLearningServicePrincipalDatastoreSecrets Secrets { get; set; }
        /// <summary> [Required] ID of the tenant to which the service principal belongs. </summary>
        public Guid TenantId { get; set; }
    }
}
