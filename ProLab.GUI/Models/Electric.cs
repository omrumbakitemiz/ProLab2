namespace ProLab.GUI.Models
{
    public class Electric : RepairShop
    {
        public string ChangingPart { get; set; }
        public string ChangingPrice { get; set; }
        public string LaborCost { get; set; }

        public override string ToString()
        {
            return "Changing Part: " + ChangingPart
                   + "Changing Price: " + ChangingPrice
                   + "Labor Cost " + LaborCost;
        }
    }
}
