using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class PolicyRoot : Entity, IParsable {
        /// <summary>The policy that controls the idle time out for web sessions for applications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ActivityBasedTimeoutPolicy>? ActivityBasedTimeoutPolicies {
            get { return BackingStore?.Get<List<ActivityBasedTimeoutPolicy>?>("activityBasedTimeoutPolicies"); }
            set { BackingStore?.Set("activityBasedTimeoutPolicies", value); }
        }
#nullable restore
#else
        public List<ActivityBasedTimeoutPolicy> ActivityBasedTimeoutPolicies {
            get { return BackingStore?.Get<List<ActivityBasedTimeoutPolicy>>("activityBasedTimeoutPolicies"); }
            set { BackingStore?.Set("activityBasedTimeoutPolicies", value); }
        }
#endif
        /// <summary>The policy by which consent requests are created and managed for the entire tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AdminConsentRequestPolicy? AdminConsentRequestPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AdminConsentRequestPolicy?>("adminConsentRequestPolicy"); }
            set { BackingStore?.Set("adminConsentRequestPolicy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AdminConsentRequestPolicy AdminConsentRequestPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AdminConsentRequestPolicy>("adminConsentRequestPolicy"); }
            set { BackingStore?.Set("adminConsentRequestPolicy", value); }
        }
#endif
        /// <summary>The appManagementPolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppManagementPolicy>? AppManagementPolicies {
            get { return BackingStore?.Get<List<AppManagementPolicy>?>("appManagementPolicies"); }
            set { BackingStore?.Set("appManagementPolicies", value); }
        }
#nullable restore
#else
        public List<AppManagementPolicy> AppManagementPolicies {
            get { return BackingStore?.Get<List<AppManagementPolicy>>("appManagementPolicies"); }
            set { BackingStore?.Set("appManagementPolicies", value); }
        }
#endif
        /// <summary>The policy configuration of the self-service sign-up experience of external users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AuthenticationFlowsPolicy? AuthenticationFlowsPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AuthenticationFlowsPolicy?>("authenticationFlowsPolicy"); }
            set { BackingStore?.Set("authenticationFlowsPolicy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AuthenticationFlowsPolicy AuthenticationFlowsPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AuthenticationFlowsPolicy>("authenticationFlowsPolicy"); }
            set { BackingStore?.Set("authenticationFlowsPolicy", value); }
        }
#endif
        /// <summary>The authentication methods and the users that are allowed to use them to sign in and perform multi-factor authentication (MFA) in Azure Active Directory (Azure AD).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AuthenticationMethodsPolicy? AuthenticationMethodsPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AuthenticationMethodsPolicy?>("authenticationMethodsPolicy"); }
            set { BackingStore?.Set("authenticationMethodsPolicy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AuthenticationMethodsPolicy AuthenticationMethodsPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AuthenticationMethodsPolicy>("authenticationMethodsPolicy"); }
            set { BackingStore?.Set("authenticationMethodsPolicy", value); }
        }
#endif
        /// <summary>The policy that controls Azure AD authorization settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AuthorizationPolicy? AuthorizationPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AuthorizationPolicy?>("authorizationPolicy"); }
            set { BackingStore?.Set("authorizationPolicy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AuthorizationPolicy AuthorizationPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AuthorizationPolicy>("authorizationPolicy"); }
            set { BackingStore?.Set("authorizationPolicy", value); }
        }
#endif
        /// <summary>The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClaimsMappingPolicy>? ClaimsMappingPolicies {
            get { return BackingStore?.Get<List<ClaimsMappingPolicy>?>("claimsMappingPolicies"); }
            set { BackingStore?.Set("claimsMappingPolicies", value); }
        }
#nullable restore
#else
        public List<ClaimsMappingPolicy> ClaimsMappingPolicies {
            get { return BackingStore?.Get<List<ClaimsMappingPolicy>>("claimsMappingPolicies"); }
            set { BackingStore?.Set("claimsMappingPolicies", value); }
        }
#endif
        /// <summary>The custom rules that define an access scenario.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConditionalAccessPolicy>? ConditionalAccessPolicies {
            get { return BackingStore?.Get<List<ConditionalAccessPolicy>?>("conditionalAccessPolicies"); }
            set { BackingStore?.Set("conditionalAccessPolicies", value); }
        }
#nullable restore
#else
        public List<ConditionalAccessPolicy> ConditionalAccessPolicies {
            get { return BackingStore?.Get<List<ConditionalAccessPolicy>>("conditionalAccessPolicies"); }
            set { BackingStore?.Set("conditionalAccessPolicies", value); }
        }
#endif
        /// <summary>The custom rules that define an access scenario when interacting with external Azure AD tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.CrossTenantAccessPolicy? CrossTenantAccessPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CrossTenantAccessPolicy?>("crossTenantAccessPolicy"); }
            set { BackingStore?.Set("crossTenantAccessPolicy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.CrossTenantAccessPolicy CrossTenantAccessPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CrossTenantAccessPolicy>("crossTenantAccessPolicy"); }
            set { BackingStore?.Set("crossTenantAccessPolicy", value); }
        }
#endif
        /// <summary>The defaultAppManagementPolicy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TenantAppManagementPolicy? DefaultAppManagementPolicy {
            get { return BackingStore?.Get<TenantAppManagementPolicy?>("defaultAppManagementPolicy"); }
            set { BackingStore?.Set("defaultAppManagementPolicy", value); }
        }
#nullable restore
#else
        public TenantAppManagementPolicy DefaultAppManagementPolicy {
            get { return BackingStore?.Get<TenantAppManagementPolicy>("defaultAppManagementPolicy"); }
            set { BackingStore?.Set("defaultAppManagementPolicy", value); }
        }
#endif
        /// <summary>The feature rollout policy associated with a directory object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FeatureRolloutPolicy>? FeatureRolloutPolicies {
            get { return BackingStore?.Get<List<FeatureRolloutPolicy>?>("featureRolloutPolicies"); }
            set { BackingStore?.Set("featureRolloutPolicies", value); }
        }
#nullable restore
#else
        public List<FeatureRolloutPolicy> FeatureRolloutPolicies {
            get { return BackingStore?.Get<List<FeatureRolloutPolicy>>("featureRolloutPolicies"); }
            set { BackingStore?.Set("featureRolloutPolicies", value); }
        }
#endif
        /// <summary>The policy to control Azure AD authentication behavior for federated users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HomeRealmDiscoveryPolicy>? HomeRealmDiscoveryPolicies {
            get { return BackingStore?.Get<List<HomeRealmDiscoveryPolicy>?>("homeRealmDiscoveryPolicies"); }
            set { BackingStore?.Set("homeRealmDiscoveryPolicies", value); }
        }
#nullable restore
#else
        public List<HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies {
            get { return BackingStore?.Get<List<HomeRealmDiscoveryPolicy>>("homeRealmDiscoveryPolicies"); }
            set { BackingStore?.Set("homeRealmDiscoveryPolicies", value); }
        }
#endif
        /// <summary>The policy that represents the security defaults that protect against common attacks.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.IdentitySecurityDefaultsEnforcementPolicy? IdentitySecurityDefaultsEnforcementPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentitySecurityDefaultsEnforcementPolicy?>("identitySecurityDefaultsEnforcementPolicy"); }
            set { BackingStore?.Set("identitySecurityDefaultsEnforcementPolicy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.IdentitySecurityDefaultsEnforcementPolicy IdentitySecurityDefaultsEnforcementPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentitySecurityDefaultsEnforcementPolicy>("identitySecurityDefaultsEnforcementPolicy"); }
            set { BackingStore?.Set("identitySecurityDefaultsEnforcementPolicy", value); }
        }
#endif
        /// <summary>The policy that specifies the conditions under which consent can be granted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PermissionGrantPolicy>? PermissionGrantPolicies {
            get { return BackingStore?.Get<List<PermissionGrantPolicy>?>("permissionGrantPolicies"); }
            set { BackingStore?.Set("permissionGrantPolicies", value); }
        }
#nullable restore
#else
        public List<PermissionGrantPolicy> PermissionGrantPolicies {
            get { return BackingStore?.Get<List<PermissionGrantPolicy>>("permissionGrantPolicies"); }
            set { BackingStore?.Set("permissionGrantPolicies", value); }
        }
#endif
        /// <summary>Specifies the various policies associated with scopes and roles.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleManagementPolicy>? RoleManagementPolicies {
            get { return BackingStore?.Get<List<UnifiedRoleManagementPolicy>?>("roleManagementPolicies"); }
            set { BackingStore?.Set("roleManagementPolicies", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleManagementPolicy> RoleManagementPolicies {
            get { return BackingStore?.Get<List<UnifiedRoleManagementPolicy>>("roleManagementPolicies"); }
            set { BackingStore?.Set("roleManagementPolicies", value); }
        }
#endif
        /// <summary>The assignment of a role management policy to a role definition object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleManagementPolicyAssignment>? RoleManagementPolicyAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleManagementPolicyAssignment>?>("roleManagementPolicyAssignments"); }
            set { BackingStore?.Set("roleManagementPolicyAssignments", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleManagementPolicyAssignment> RoleManagementPolicyAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleManagementPolicyAssignment>>("roleManagementPolicyAssignments"); }
            set { BackingStore?.Set("roleManagementPolicyAssignments", value); }
        }
#endif
        /// <summary>The policy that specifies the characteristics of SAML tokens issued by Azure AD.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TokenIssuancePolicy>? TokenIssuancePolicies {
            get { return BackingStore?.Get<List<TokenIssuancePolicy>?>("tokenIssuancePolicies"); }
            set { BackingStore?.Set("tokenIssuancePolicies", value); }
        }
#nullable restore
#else
        public List<TokenIssuancePolicy> TokenIssuancePolicies {
            get { return BackingStore?.Get<List<TokenIssuancePolicy>>("tokenIssuancePolicies"); }
            set { BackingStore?.Set("tokenIssuancePolicies", value); }
        }
#endif
        /// <summary>The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TokenLifetimePolicy>? TokenLifetimePolicies {
            get { return BackingStore?.Get<List<TokenLifetimePolicy>?>("tokenLifetimePolicies"); }
            set { BackingStore?.Set("tokenLifetimePolicies", value); }
        }
#nullable restore
#else
        public List<TokenLifetimePolicy> TokenLifetimePolicies {
            get { return BackingStore?.Get<List<TokenLifetimePolicy>>("tokenLifetimePolicies"); }
            set { BackingStore?.Set("tokenLifetimePolicies", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PolicyRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PolicyRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activityBasedTimeoutPolicies", n => { ActivityBasedTimeoutPolicies = n.GetCollectionOfObjectValues<ActivityBasedTimeoutPolicy>(ActivityBasedTimeoutPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"adminConsentRequestPolicy", n => { AdminConsentRequestPolicy = n.GetObjectValue<Microsoft.Graph.Models.AdminConsentRequestPolicy>(Microsoft.Graph.Models.AdminConsentRequestPolicy.CreateFromDiscriminatorValue); } },
                {"appManagementPolicies", n => { AppManagementPolicies = n.GetCollectionOfObjectValues<AppManagementPolicy>(AppManagementPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authenticationFlowsPolicy", n => { AuthenticationFlowsPolicy = n.GetObjectValue<Microsoft.Graph.Models.AuthenticationFlowsPolicy>(Microsoft.Graph.Models.AuthenticationFlowsPolicy.CreateFromDiscriminatorValue); } },
                {"authenticationMethodsPolicy", n => { AuthenticationMethodsPolicy = n.GetObjectValue<Microsoft.Graph.Models.AuthenticationMethodsPolicy>(Microsoft.Graph.Models.AuthenticationMethodsPolicy.CreateFromDiscriminatorValue); } },
                {"authorizationPolicy", n => { AuthorizationPolicy = n.GetObjectValue<Microsoft.Graph.Models.AuthorizationPolicy>(Microsoft.Graph.Models.AuthorizationPolicy.CreateFromDiscriminatorValue); } },
                {"claimsMappingPolicies", n => { ClaimsMappingPolicies = n.GetCollectionOfObjectValues<ClaimsMappingPolicy>(ClaimsMappingPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditionalAccessPolicies", n => { ConditionalAccessPolicies = n.GetCollectionOfObjectValues<ConditionalAccessPolicy>(ConditionalAccessPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"crossTenantAccessPolicy", n => { CrossTenantAccessPolicy = n.GetObjectValue<Microsoft.Graph.Models.CrossTenantAccessPolicy>(Microsoft.Graph.Models.CrossTenantAccessPolicy.CreateFromDiscriminatorValue); } },
                {"defaultAppManagementPolicy", n => { DefaultAppManagementPolicy = n.GetObjectValue<TenantAppManagementPolicy>(TenantAppManagementPolicy.CreateFromDiscriminatorValue); } },
                {"featureRolloutPolicies", n => { FeatureRolloutPolicies = n.GetCollectionOfObjectValues<FeatureRolloutPolicy>(FeatureRolloutPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"homeRealmDiscoveryPolicies", n => { HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<HomeRealmDiscoveryPolicy>(HomeRealmDiscoveryPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"identitySecurityDefaultsEnforcementPolicy", n => { IdentitySecurityDefaultsEnforcementPolicy = n.GetObjectValue<Microsoft.Graph.Models.IdentitySecurityDefaultsEnforcementPolicy>(Microsoft.Graph.Models.IdentitySecurityDefaultsEnforcementPolicy.CreateFromDiscriminatorValue); } },
                {"permissionGrantPolicies", n => { PermissionGrantPolicies = n.GetCollectionOfObjectValues<PermissionGrantPolicy>(PermissionGrantPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleManagementPolicies", n => { RoleManagementPolicies = n.GetCollectionOfObjectValues<UnifiedRoleManagementPolicy>(UnifiedRoleManagementPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleManagementPolicyAssignments", n => { RoleManagementPolicyAssignments = n.GetCollectionOfObjectValues<UnifiedRoleManagementPolicyAssignment>(UnifiedRoleManagementPolicyAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tokenIssuancePolicies", n => { TokenIssuancePolicies = n.GetCollectionOfObjectValues<TokenIssuancePolicy>(TokenIssuancePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tokenLifetimePolicies", n => { TokenLifetimePolicies = n.GetCollectionOfObjectValues<TokenLifetimePolicy>(TokenLifetimePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ActivityBasedTimeoutPolicy>("activityBasedTimeoutPolicies", ActivityBasedTimeoutPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Models.AdminConsentRequestPolicy>("adminConsentRequestPolicy", AdminConsentRequestPolicy);
            writer.WriteCollectionOfObjectValues<AppManagementPolicy>("appManagementPolicies", AppManagementPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Models.AuthenticationFlowsPolicy>("authenticationFlowsPolicy", AuthenticationFlowsPolicy);
            writer.WriteObjectValue<Microsoft.Graph.Models.AuthenticationMethodsPolicy>("authenticationMethodsPolicy", AuthenticationMethodsPolicy);
            writer.WriteObjectValue<Microsoft.Graph.Models.AuthorizationPolicy>("authorizationPolicy", AuthorizationPolicy);
            writer.WriteCollectionOfObjectValues<ClaimsMappingPolicy>("claimsMappingPolicies", ClaimsMappingPolicies);
            writer.WriteCollectionOfObjectValues<ConditionalAccessPolicy>("conditionalAccessPolicies", ConditionalAccessPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Models.CrossTenantAccessPolicy>("crossTenantAccessPolicy", CrossTenantAccessPolicy);
            writer.WriteObjectValue<TenantAppManagementPolicy>("defaultAppManagementPolicy", DefaultAppManagementPolicy);
            writer.WriteCollectionOfObjectValues<FeatureRolloutPolicy>("featureRolloutPolicies", FeatureRolloutPolicies);
            writer.WriteCollectionOfObjectValues<HomeRealmDiscoveryPolicy>("homeRealmDiscoveryPolicies", HomeRealmDiscoveryPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Models.IdentitySecurityDefaultsEnforcementPolicy>("identitySecurityDefaultsEnforcementPolicy", IdentitySecurityDefaultsEnforcementPolicy);
            writer.WriteCollectionOfObjectValues<PermissionGrantPolicy>("permissionGrantPolicies", PermissionGrantPolicies);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementPolicy>("roleManagementPolicies", RoleManagementPolicies);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementPolicyAssignment>("roleManagementPolicyAssignments", RoleManagementPolicyAssignments);
            writer.WriteCollectionOfObjectValues<TokenIssuancePolicy>("tokenIssuancePolicies", TokenIssuancePolicies);
            writer.WriteCollectionOfObjectValues<TokenLifetimePolicy>("tokenLifetimePolicies", TokenLifetimePolicies);
        }
    }
}
