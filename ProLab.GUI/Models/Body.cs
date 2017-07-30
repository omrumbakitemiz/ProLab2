namespace ProLab.GUI.Models
{
    public class Body : RepairShop
    {
        public string ChangingPart { get; set; }
        public string ChangingPrice { get; set; }
        public string PaintingPart { get; set; }
        public string PaintingPrice { get; set; }
        public string LaborCost { get; set; }

        public override string ToString()
        {
            return "Changing Part: "+ ChangingPart
                + "Changing Price: "+ ChangingPrice
                + "Painting Part: "+ PaintingPart
                + "Painting Cost: "+ PaintingPrice
                + "Labor Cost "+ LaborCost;
        }
    }
}
