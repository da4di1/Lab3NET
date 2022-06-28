using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    public class AMDSysUnitBuilder : SystemUnitBuilder
    {
        public override void SetBox()
        {
            SystemUnit.Box = new Box() { Name = "Corsair Carbide 275R", Type = "Miditower", Material = "Steel", Color = "White" };
        }

        public override void SetProcessor()
        {
            SystemUnit.Processor = new Processor() { Name = "AMD Ryzen 5 5600G", Family = "AMD Ryzen 5", NumOfCores = 6 };
        }

        public override void SetMainBoard()
        {
            SystemUnit.MainBoard = new MainBoard() { Name = "Asus Prime B450M-A II", Chipset = "AMD B450" };
        }

        public override void SetHdd()
        {
            SystemUnit.Hdd = new Hdd() { Name = "Transcend StoreJet 25M3C", Type = "External", Capacity = 4000 };
        }

        public override void SetMemory()
        {
        }
    }
}
