namespace ProLab.GUI.Models
{
    public class Tire : RepairShop
    {
        public string ChangingTire { get; set; }
        public string Piece { get; set; }
        public string Cost { get; set; }
        public string LaborCost { get; set; }

        public override string ToString()
        {
            return "Changed Tire: " + ChangingTire
                   + "Piece: " + Piece
                   + "Cost: " + Cost
                   + "Labor Cost " + LaborCost;
        }
    }
}
