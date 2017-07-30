namespace ProLab.GUI.Models
{
    public class Engine : RepairShop
    {
        public string ChangingPart { get; set; }
        public string ChangingPrice { get; set; }
        public string RepairingPart { get; set; }
        public string RepairingPrice { get; set; }
        public string LaborCost { get; set; }

        public override string ToString()
        {
            return "Changing Part: " + ChangingPart
                   + "Changing Price: " + ChangingPrice
                   + "Repairing Part: " + RepairingPart
                   + "Repairing Cost: " + RepairingPrice
                   + "Labor Cost " + LaborCost;
        }
    }
}
