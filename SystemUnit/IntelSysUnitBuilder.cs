using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    public class IntelSysUnitBuilder : SystemUnitBuilder
    {
        public override void SetBox()
        {
            SystemUnit.Box = new Box() { Name = "RZTK PcCooler Master", Type = "Miditower", Material = "Metal", Color = "Black" };
        }

        public override void SetProcessor()
        {
            SystemUnit.Processor = new Processor() { Name = "Intel Core i9-12900K", Family = "Intel Core i9", NumOfCores = 16 };
        }

        public override void SetMainBoard()
        {
            SystemUnit.MainBoard = new MainBoard() { Name = "Asus Prime H510M-A", Chipset = "Intel H510" };
        }

        public override void SetHdd()
        {
            SystemUnit.Hdd = new Hdd() { Name = "Seagate SkyHawk Al", Type = "Internal", Capacity = 18000 };
        }

        public override void SetMemory()
        {
            SystemUnit.Memory = new Memory() { Name = "Kingston Fury DDR4-3200", Volume = 16 };
        }
    }
}
