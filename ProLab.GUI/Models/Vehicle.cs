using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab.GUI.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            BodyJob = new Body()
            {
                ChangingPart = "parca1",
                ChangingPrice = "fiyat1",
                LaborCost = "100",
                PaintingPart = "parca2",
                PaintingPrice = "100",
                RepairMan = "usta1",
                Status = Status.RepairingHasntStartedYet
            };

            ElectricJob = new Electric()
            {
                ChangingPart = "parca2",
                ChangingPrice = "fiyat2",
                LaborCost = "100",
                RepairMan = "usta2",
                Status = Status.RepairingHasntStartedYet
            };

            EngineJob = new Engine()
            {
                ChangingPart = "parca3",
                ChangingPrice = "fiyat3",
                LaborCost = "100",
                RepairMan = "usta2",
                Status = Status.RepairingHasntStartedYet
            };

            TireJob = new Tire()
            {
                ChangingTire = "parca6",
                Cost = "100",
                LaborCost = "50",
                Piece = "4",
                RepairMan = "usta3",
                Status = Status.RepairingHasntStartedYet
            };
        }

        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }

        public Body BodyJob { get; set; }
        public Electric ElectricJob { get; set; }
        public Engine EngineJob { get; set; }
        public Tire TireJob { get; set; }

        public void AddRepairing(Body body)
        {
            BodyJob = body;
        }

        public void AddRepairing(Electric electric)
        {
            ElectricJob = electric;
        }

        public void AddRepairing(Engine engine)
        {
            EngineJob = engine;
        }

        public void AddRepairing(Tire tire)
        {
            TireJob = tire;
        }
    }
}
