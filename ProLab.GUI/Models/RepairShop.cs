namespace ProLab.GUI.Models
{
    public class RepairShop
    {
        public Status Status { get; set; }
        public string RepairMan { get; set; }
    }

    public enum Status
    {
        RepairingHasntStartedYet = 1,
        RepairingInProgress,
        RepairingDone
    }
}
