using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class AccessReviewScheduleDefinition : Entity, IParsable {
        /// <summary>Defines the list of additional users or group members to be notified of the access review progress.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<AccessReviewNotificationRecipientItem>? AdditionalNotificationRecipients {
            get { return BackingStore?.Get<List<AccessReviewNotificationRecipientItem>?>("additionalNotificationRecipients"); }
            set { BackingStore?.Set("additionalNotificationRecipients", value); }
        }
#else
        public List<AccessReviewNotificationRecipientItem> AdditionalNotificationRecipients {
            get { return BackingStore?.Get<List<AccessReviewNotificationRecipientItem>>("additionalNotificationRecipients"); }
            set { BackingStore?.Set("additionalNotificationRecipients", value); }
        }
#endif
        /// <summary>User who created this review. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public UserIdentity? CreatedBy {
            get { return BackingStore?.Get<UserIdentity?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#else
        public UserIdentity CreatedBy {
            get { return BackingStore?.Get<UserIdentity>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Timestamp when the access review series was created. Supports $select. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description provided by review creators to provide more context of the review to admins. Supports $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DescriptionForAdmins {
            get { return BackingStore?.Get<string?>("descriptionForAdmins"); }
            set { BackingStore?.Set("descriptionForAdmins", value); }
        }
#else
        public string DescriptionForAdmins {
            get { return BackingStore?.Get<string>("descriptionForAdmins"); }
            set { BackingStore?.Set("descriptionForAdmins", value); }
        }
#endif
        /// <summary>Description provided  by review creators to provide more context of the review to reviewers. Reviewers will see this description in the email sent to them requesting their review. Email notifications support up to 256 characters. Supports $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DescriptionForReviewers {
            get { return BackingStore?.Get<string?>("descriptionForReviewers"); }
            set { BackingStore?.Set("descriptionForReviewers", value); }
        }
#else
        public string DescriptionForReviewers {
            get { return BackingStore?.Get<string>("descriptionForReviewers"); }
            set { BackingStore?.Set("descriptionForReviewers", value); }
        }
#endif
        /// <summary>Name of the access review series. Supports $select and $orderBy. Required on create.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user&apos;s manager does not exist. See accessReviewReviewerScope. Replaces backupReviewers. Supports $select. NOTE: The value of this property will be ignored if fallback reviewers are assigned through the stageSettings property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<AccessReviewReviewerScope>? FallbackReviewers {
            get { return BackingStore?.Get<List<AccessReviewReviewerScope>?>("fallbackReviewers"); }
            set { BackingStore?.Set("fallbackReviewers", value); }
        }
#else
        public List<AccessReviewReviewerScope> FallbackReviewers {
            get { return BackingStore?.Get<List<AccessReviewReviewerScope>>("fallbackReviewers"); }
            set { BackingStore?.Set("fallbackReviewers", value); }
        }
#endif
        /// <summary>This property is required when scoping a review to guest users&apos; access across all Microsoft 365 groups and determines which Microsoft 365 groups are reviewed. Each group will become a unique accessReviewInstance of the access review series.  For supported scopes, see accessReviewScope. Supports $select. For examples of options for configuring instanceEnumerationScope, see Configure the scope of your access review definition using the Microsoft Graph API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public AccessReviewScope? InstanceEnumerationScope {
            get { return BackingStore?.Get<AccessReviewScope?>("instanceEnumerationScope"); }
            set { BackingStore?.Set("instanceEnumerationScope", value); }
        }
#else
        public AccessReviewScope InstanceEnumerationScope {
            get { return BackingStore?.Get<AccessReviewScope>("instanceEnumerationScope"); }
            set { BackingStore?.Set("instanceEnumerationScope", value); }
        }
#endif
        /// <summary>If the accessReviewScheduleDefinition is a recurring access review, instances represent each recurrence. A review that does not recur will have exactly one instance. Instances also represent each unique resource under review in the accessReviewScheduleDefinition. If a review has multiple resources and multiple instances, each resource will have a unique instance for each recurrence.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<AccessReviewInstance>? Instances {
            get { return BackingStore?.Get<List<AccessReviewInstance>?>("instances"); }
            set { BackingStore?.Set("instances", value); }
        }
#else
        public List<AccessReviewInstance> Instances {
            get { return BackingStore?.Get<List<AccessReviewInstance>>("instances"); }
            set { BackingStore?.Set("instances", value); }
        }
#endif
        /// <summary>Timestamp when the access review series was last modified. Supports $select. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>This collection of access review scopes is used to define who are the reviewers. The reviewers property is only updatable if individual users are assigned as reviewers. Required on create. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API. NOTE: The value of this property will be ignored if reviewers are assigned through the stageSettings property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<AccessReviewReviewerScope>? Reviewers {
            get { return BackingStore?.Get<List<AccessReviewReviewerScope>?>("reviewers"); }
            set { BackingStore?.Set("reviewers", value); }
        }
#else
        public List<AccessReviewReviewerScope> Reviewers {
            get { return BackingStore?.Get<List<AccessReviewReviewerScope>>("reviewers"); }
            set { BackingStore?.Set("reviewers", value); }
        }
#endif
        /// <summary>Defines the entities whose access is reviewed. For supported scopes, see accessReviewScope. Required on create. Supports $select and $filter (contains only). For examples of options for configuring scope, see Configure the scope of your access review definition using the Microsoft Graph API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public AccessReviewScope? Scope {
            get { return BackingStore?.Get<AccessReviewScope?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#else
        public AccessReviewScope Scope {
            get { return BackingStore?.Get<AccessReviewScope>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#endif
        /// <summary>The settings for an access review series, see type definition below. Supports $select. Required on create.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public AccessReviewScheduleSettings? Settings {
            get { return BackingStore?.Get<AccessReviewScheduleSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#else
        public AccessReviewScheduleSettings Settings {
            get { return BackingStore?.Get<AccessReviewScheduleSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>Required only for a multi-stage access review to define the stages and their settings. You can break down each review instance into up to three sequential stages, where each stage can have a different set of reviewers, fallback reviewers, and settings. Stages will be created sequentially based on the dependsOn property. Optional.  When this property is defined, its settings are used instead of the corresponding settings in the accessReviewScheduleDefinition object and its settings, reviewers, and fallbackReviewers properties.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<AccessReviewStageSettings>? StageSettings {
            get { return BackingStore?.Get<List<AccessReviewStageSettings>?>("stageSettings"); }
            set { BackingStore?.Set("stageSettings", value); }
        }
#else
        public List<AccessReviewStageSettings> StageSettings {
            get { return BackingStore?.Get<List<AccessReviewStageSettings>>("stageSettings"); }
            set { BackingStore?.Set("stageSettings", value); }
        }
#endif
        /// <summary>This read-only field specifies the status of an access review. The typical states include Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.  Supports $select, $orderby, and $filter (eq only). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Status {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#else
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessReviewScheduleDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewScheduleDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"additionalNotificationRecipients", n => { AdditionalNotificationRecipients = n.GetCollectionOfObjectValues<AccessReviewNotificationRecipientItem>(AccessReviewNotificationRecipientItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"descriptionForAdmins", n => { DescriptionForAdmins = n.GetStringValue(); } },
                {"descriptionForReviewers", n => { DescriptionForReviewers = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"fallbackReviewers", n => { FallbackReviewers = n.GetCollectionOfObjectValues<AccessReviewReviewerScope>(AccessReviewReviewerScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"instanceEnumerationScope", n => { InstanceEnumerationScope = n.GetObjectValue<AccessReviewScope>(AccessReviewScope.CreateFromDiscriminatorValue); } },
                {"instances", n => { Instances = n.GetCollectionOfObjectValues<AccessReviewInstance>(AccessReviewInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"reviewers", n => { Reviewers = n.GetCollectionOfObjectValues<AccessReviewReviewerScope>(AccessReviewReviewerScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"scope", n => { Scope = n.GetObjectValue<AccessReviewScope>(AccessReviewScope.CreateFromDiscriminatorValue); } },
                {"settings", n => { Settings = n.GetObjectValue<AccessReviewScheduleSettings>(AccessReviewScheduleSettings.CreateFromDiscriminatorValue); } },
                {"stageSettings", n => { StageSettings = n.GetCollectionOfObjectValues<AccessReviewStageSettings>(AccessReviewStageSettings.CreateFromDiscriminatorValue)?.ToList(); } },
                {"status", n => { Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AccessReviewNotificationRecipientItem>("additionalNotificationRecipients", AdditionalNotificationRecipients);
            writer.WriteObjectValue<UserIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("descriptionForAdmins", DescriptionForAdmins);
            writer.WriteStringValue("descriptionForReviewers", DescriptionForReviewers);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<AccessReviewReviewerScope>("fallbackReviewers", FallbackReviewers);
            writer.WriteObjectValue<AccessReviewScope>("instanceEnumerationScope", InstanceEnumerationScope);
            writer.WriteCollectionOfObjectValues<AccessReviewInstance>("instances", Instances);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<AccessReviewReviewerScope>("reviewers", Reviewers);
            writer.WriteObjectValue<AccessReviewScope>("scope", Scope);
            writer.WriteObjectValue<AccessReviewScheduleSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<AccessReviewStageSettings>("stageSettings", StageSettings);
            writer.WriteStringValue("status", Status);
        }
    }
}
