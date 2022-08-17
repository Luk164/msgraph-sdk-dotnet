using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public class Alert : Entity, IParsable {
        /// <summary>Name or alias of the activity group (attacker) this alert is attributed to.</summary>
        public string ActivityGroupName {
            get { return BackingStore?.Get<string>("activityGroupName"); }
            set { BackingStore?.Set("activityGroupName", value); }
        }
        /// <summary>The alertDetections property</summary>
        public List<AlertDetection> AlertDetections {
            get { return BackingStore?.Get<List<AlertDetection>>("alertDetections"); }
            set { BackingStore?.Set("alertDetections", value); }
        }
        /// <summary>Name of the analyst the alert is assigned to for triage, investigation, or remediation (supports update).</summary>
        public string AssignedTo {
            get { return BackingStore?.Get<string>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
        /// <summary>Azure subscription ID, present if this alert is related to an Azure resource.</summary>
        public string AzureSubscriptionId {
            get { return BackingStore?.Get<string>("azureSubscriptionId"); }
            set { BackingStore?.Set("azureSubscriptionId", value); }
        }
        /// <summary>Azure Active Directory tenant ID. Required.</summary>
        public string AzureTenantId {
            get { return BackingStore?.Get<string>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
        /// <summary>Category of the alert (for example, credentialTheft, ransomware, etc.).</summary>
        public string Category {
            get { return BackingStore?.Get<string>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>Time at which the alert was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z (supports update).</summary>
        public DateTimeOffset? ClosedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("closedDateTime"); }
            set { BackingStore?.Set("closedDateTime", value); }
        }
        /// <summary>Security-related stateful information generated by the provider about the cloud application/s related to this alert.</summary>
        public List<CloudAppSecurityState> CloudAppStates {
            get { return BackingStore?.Get<List<CloudAppSecurityState>>("cloudAppStates"); }
            set { BackingStore?.Set("cloudAppStates", value); }
        }
        /// <summary>Customer-provided comments on alert (for customer alert management) (supports update).</summary>
        public List<string> Comments {
            get { return BackingStore?.Get<List<string>>("comments"); }
            set { BackingStore?.Set("comments", value); }
        }
        /// <summary>Confidence of the detection logic (percentage between 1-100).</summary>
        public int? Confidence {
            get { return BackingStore?.Get<int?>("confidence"); }
            set { BackingStore?.Set("confidence", value); }
        }
        /// <summary>Time at which the alert was created by the alert provider. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Alert description.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Set of alerts related to this alert entity (each alert is pushed to the SIEM as a separate record).</summary>
        public List<string> DetectionIds {
            get { return BackingStore?.Get<List<string>>("detectionIds"); }
            set { BackingStore?.Set("detectionIds", value); }
        }
        /// <summary>Time at which the event(s) that served as the trigger(s) to generate the alert occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.</summary>
        public DateTimeOffset? EventDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("eventDateTime"); }
            set { BackingStore?.Set("eventDateTime", value); }
        }
        /// <summary>Analyst feedback on the alert. Possible values are: unknown, truePositive, falsePositive, benignPositive. (supports update)</summary>
        public AlertFeedback? Feedback {
            get { return BackingStore?.Get<AlertFeedback?>("feedback"); }
            set { BackingStore?.Set("feedback", value); }
        }
        /// <summary>Security-related stateful information generated by the provider about the file(s) related to this alert.</summary>
        public List<FileSecurityState> FileStates {
            get { return BackingStore?.Get<List<FileSecurityState>>("fileStates"); }
            set { BackingStore?.Set("fileStates", value); }
        }
        /// <summary>The historyStates property</summary>
        public List<AlertHistoryState> HistoryStates {
            get { return BackingStore?.Get<List<AlertHistoryState>>("historyStates"); }
            set { BackingStore?.Set("historyStates", value); }
        }
        /// <summary>Security-related stateful information generated by the provider about the host(s) related to this alert.</summary>
        public List<HostSecurityState> HostStates {
            get { return BackingStore?.Get<List<HostSecurityState>>("hostStates"); }
            set { BackingStore?.Set("hostStates", value); }
        }
        /// <summary>IDs of incidents related to current alert.</summary>
        public List<string> IncidentIds {
            get { return BackingStore?.Get<List<string>>("incidentIds"); }
            set { BackingStore?.Set("incidentIds", value); }
        }
        /// <summary>The investigationSecurityStates property</summary>
        public List<InvestigationSecurityState> InvestigationSecurityStates {
            get { return BackingStore?.Get<List<InvestigationSecurityState>>("investigationSecurityStates"); }
            set { BackingStore?.Set("investigationSecurityStates", value); }
        }
        /// <summary>The lastEventDateTime property</summary>
        public DateTimeOffset? LastEventDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastEventDateTime"); }
            set { BackingStore?.Set("lastEventDateTime", value); }
        }
        /// <summary>Time at which the alert entity was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Threat Intelligence pertaining to malware related to this alert.</summary>
        public List<MalwareState> MalwareStates {
            get { return BackingStore?.Get<List<MalwareState>>("malwareStates"); }
            set { BackingStore?.Set("malwareStates", value); }
        }
        /// <summary>The messageSecurityStates property</summary>
        public List<MessageSecurityState> MessageSecurityStates {
            get { return BackingStore?.Get<List<MessageSecurityState>>("messageSecurityStates"); }
            set { BackingStore?.Set("messageSecurityStates", value); }
        }
        /// <summary>Security-related stateful information generated by the provider about the network connection(s) related to this alert.</summary>
        public List<NetworkConnection> NetworkConnections {
            get { return BackingStore?.Get<List<NetworkConnection>>("networkConnections"); }
            set { BackingStore?.Set("networkConnections", value); }
        }
        /// <summary>Security-related stateful information generated by the provider about the process or processes related to this alert.</summary>
        public List<Process> Processes {
            get { return BackingStore?.Get<List<Process>>("processes"); }
            set { BackingStore?.Set("processes", value); }
        }
        /// <summary>Vendor/provider recommended action(s) to take as a result of the alert (for example, isolate machine, enforce2FA, reimage host).</summary>
        public List<string> RecommendedActions {
            get { return BackingStore?.Get<List<string>>("recommendedActions"); }
            set { BackingStore?.Set("recommendedActions", value); }
        }
        /// <summary>Security-related stateful information generated by the provider about the registry keys related to this alert.</summary>
        public List<RegistryKeyState> RegistryKeyStates {
            get { return BackingStore?.Get<List<RegistryKeyState>>("registryKeyStates"); }
            set { BackingStore?.Set("registryKeyStates", value); }
        }
        /// <summary>Resources related to current alert. For example, for some alerts this can have the Azure Resource value.</summary>
        public List<SecurityResource> SecurityResources {
            get { return BackingStore?.Get<List<SecurityResource>>("securityResources"); }
            set { BackingStore?.Set("securityResources", value); }
        }
        /// <summary>The severity property</summary>
        public AlertSeverity? Severity {
            get { return BackingStore?.Get<AlertSeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>Hyperlinks (URIs) to the source material related to the alert, for example, provider&apos;s user interface for alerts or log search, etc.</summary>
        public List<string> SourceMaterials {
            get { return BackingStore?.Get<List<string>>("sourceMaterials"); }
            set { BackingStore?.Set("sourceMaterials", value); }
        }
        /// <summary>The status property</summary>
        public AlertStatus? Status {
            get { return BackingStore?.Get<AlertStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>User-definable labels that can be applied to an alert and can serve as filter conditions (for example &apos;HVA&apos;, &apos;SAW&apos;, etc.) (supports update).</summary>
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
        /// <summary>Alert title. Required.</summary>
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
        /// <summary>Security-related information about the specific properties that triggered the alert (properties appearing in the alert). Alerts might contain information about multiple users, hosts, files, ip addresses. This field indicates which properties triggered the alert generation.</summary>
        public List<AlertTrigger> Triggers {
            get { return BackingStore?.Get<List<AlertTrigger>>("triggers"); }
            set { BackingStore?.Set("triggers", value); }
        }
        /// <summary>The uriClickSecurityStates property</summary>
        public List<UriClickSecurityState> UriClickSecurityStates {
            get { return BackingStore?.Get<List<UriClickSecurityState>>("uriClickSecurityStates"); }
            set { BackingStore?.Set("uriClickSecurityStates", value); }
        }
        /// <summary>Security-related stateful information generated by the provider about the user accounts related to this alert.</summary>
        public List<UserSecurityState> UserStates {
            get { return BackingStore?.Get<List<UserSecurityState>>("userStates"); }
            set { BackingStore?.Set("userStates", value); }
        }
        /// <summary>Complex type containing details about the security product/service vendor, provider, and subprovider (for example, vendor=Microsoft; provider=Windows Defender ATP; subProvider=AppLocker). Required.</summary>
        public SecurityVendorInformation VendorInformation {
            get { return BackingStore?.Get<SecurityVendorInformation>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
        /// <summary>Threat intelligence pertaining to one or more vulnerabilities related to this alert.</summary>
        public List<VulnerabilityState> VulnerabilityStates {
            get { return BackingStore?.Get<List<VulnerabilityState>>("vulnerabilityStates"); }
            set { BackingStore?.Set("vulnerabilityStates", value); }
        }
        /// <summary>
        /// Instantiates a new alert and sets the default values.
        /// </summary>
        public Alert() : base() {
            OdataType = "#microsoft.graph.alert";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Alert CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Alert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activityGroupName", n => { ActivityGroupName = n.GetStringValue(); } },
                {"alertDetections", n => { AlertDetections = n.GetCollectionOfObjectValues<AlertDetection>(AlertDetection.CreateFromDiscriminatorValue).ToList(); } },
                {"assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                {"azureSubscriptionId", n => { AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"category", n => { Category = n.GetStringValue(); } },
                {"closedDateTime", n => { ClosedDateTime = n.GetDateTimeOffsetValue(); } },
                {"cloudAppStates", n => { CloudAppStates = n.GetCollectionOfObjectValues<CloudAppSecurityState>(CloudAppSecurityState.CreateFromDiscriminatorValue).ToList(); } },
                {"comments", n => { Comments = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"confidence", n => { Confidence = n.GetIntValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"detectionIds", n => { DetectionIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"feedback", n => { Feedback = n.GetEnumValue<AlertFeedback>(); } },
                {"fileStates", n => { FileStates = n.GetCollectionOfObjectValues<FileSecurityState>(FileSecurityState.CreateFromDiscriminatorValue).ToList(); } },
                {"historyStates", n => { HistoryStates = n.GetCollectionOfObjectValues<AlertHistoryState>(AlertHistoryState.CreateFromDiscriminatorValue).ToList(); } },
                {"hostStates", n => { HostStates = n.GetCollectionOfObjectValues<HostSecurityState>(HostSecurityState.CreateFromDiscriminatorValue).ToList(); } },
                {"incidentIds", n => { IncidentIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"investigationSecurityStates", n => { InvestigationSecurityStates = n.GetCollectionOfObjectValues<InvestigationSecurityState>(InvestigationSecurityState.CreateFromDiscriminatorValue).ToList(); } },
                {"lastEventDateTime", n => { LastEventDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"malwareStates", n => { MalwareStates = n.GetCollectionOfObjectValues<MalwareState>(MalwareState.CreateFromDiscriminatorValue).ToList(); } },
                {"messageSecurityStates", n => { MessageSecurityStates = n.GetCollectionOfObjectValues<MessageSecurityState>(MessageSecurityState.CreateFromDiscriminatorValue).ToList(); } },
                {"networkConnections", n => { NetworkConnections = n.GetCollectionOfObjectValues<NetworkConnection>(NetworkConnection.CreateFromDiscriminatorValue).ToList(); } },
                {"processes", n => { Processes = n.GetCollectionOfObjectValues<Process>(Process.CreateFromDiscriminatorValue).ToList(); } },
                {"recommendedActions", n => { RecommendedActions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"registryKeyStates", n => { RegistryKeyStates = n.GetCollectionOfObjectValues<RegistryKeyState>(RegistryKeyState.CreateFromDiscriminatorValue).ToList(); } },
                {"securityResources", n => { SecurityResources = n.GetCollectionOfObjectValues<SecurityResource>(SecurityResource.CreateFromDiscriminatorValue).ToList(); } },
                {"severity", n => { Severity = n.GetEnumValue<AlertSeverity>(); } },
                {"sourceMaterials", n => { SourceMaterials = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"status", n => { Status = n.GetEnumValue<AlertStatus>(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"triggers", n => { Triggers = n.GetCollectionOfObjectValues<AlertTrigger>(AlertTrigger.CreateFromDiscriminatorValue).ToList(); } },
                {"uriClickSecurityStates", n => { UriClickSecurityStates = n.GetCollectionOfObjectValues<UriClickSecurityState>(UriClickSecurityState.CreateFromDiscriminatorValue).ToList(); } },
                {"userStates", n => { UserStates = n.GetCollectionOfObjectValues<UserSecurityState>(UserSecurityState.CreateFromDiscriminatorValue).ToList(); } },
                {"vendorInformation", n => { VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
                {"vulnerabilityStates", n => { VulnerabilityStates = n.GetCollectionOfObjectValues<VulnerabilityState>(VulnerabilityState.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activityGroupName", ActivityGroupName);
            writer.WriteCollectionOfObjectValues<AlertDetection>("alertDetections", AlertDetections);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteStringValue("category", Category);
            writer.WriteDateTimeOffsetValue("closedDateTime", ClosedDateTime);
            writer.WriteCollectionOfObjectValues<CloudAppSecurityState>("cloudAppStates", CloudAppStates);
            writer.WriteCollectionOfPrimitiveValues<string>("comments", Comments);
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfPrimitiveValues<string>("detectionIds", DetectionIds);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteEnumValue<AlertFeedback>("feedback", Feedback);
            writer.WriteCollectionOfObjectValues<FileSecurityState>("fileStates", FileStates);
            writer.WriteCollectionOfObjectValues<AlertHistoryState>("historyStates", HistoryStates);
            writer.WriteCollectionOfObjectValues<HostSecurityState>("hostStates", HostStates);
            writer.WriteCollectionOfPrimitiveValues<string>("incidentIds", IncidentIds);
            writer.WriteCollectionOfObjectValues<InvestigationSecurityState>("investigationSecurityStates", InvestigationSecurityStates);
            writer.WriteDateTimeOffsetValue("lastEventDateTime", LastEventDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<MalwareState>("malwareStates", MalwareStates);
            writer.WriteCollectionOfObjectValues<MessageSecurityState>("messageSecurityStates", MessageSecurityStates);
            writer.WriteCollectionOfObjectValues<NetworkConnection>("networkConnections", NetworkConnections);
            writer.WriteCollectionOfObjectValues<Process>("processes", Processes);
            writer.WriteCollectionOfPrimitiveValues<string>("recommendedActions", RecommendedActions);
            writer.WriteCollectionOfObjectValues<RegistryKeyState>("registryKeyStates", RegistryKeyStates);
            writer.WriteCollectionOfObjectValues<SecurityResource>("securityResources", SecurityResources);
            writer.WriteEnumValue<AlertSeverity>("severity", Severity);
            writer.WriteCollectionOfPrimitiveValues<string>("sourceMaterials", SourceMaterials);
            writer.WriteEnumValue<AlertStatus>("status", Status);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("title", Title);
            writer.WriteCollectionOfObjectValues<AlertTrigger>("triggers", Triggers);
            writer.WriteCollectionOfObjectValues<UriClickSecurityState>("uriClickSecurityStates", UriClickSecurityStates);
            writer.WriteCollectionOfObjectValues<UserSecurityState>("userStates", UserStates);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
            writer.WriteCollectionOfObjectValues<VulnerabilityState>("vulnerabilityStates", VulnerabilityStates);
        }
    }
}
