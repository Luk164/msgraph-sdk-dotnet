namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the drive singleton.</summary>
    public enum ActionState {
        None,
        Pending,
        Canceled,
        Active,
        Done,
        Failed,
        NotSupported,
    }
}
