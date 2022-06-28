using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    public class SystemUnit
    {
        public Box Box { get; set; }
        public Processor Processor { get; set; }
        public MainBoard MainBoard { get; set; }
        public Hdd Hdd { get; set; }
        public Memory Memory { get; set; }

        public override string ToString()
        {
            string boxString;
            if (Box != null)
                boxString = $"Box: \n\tName: {Box.Name}: \n\tType: {Box.Type}; \n\tMaterial: {Box.Material}; \n\tColor: {Box.Color};";
            else
                boxString = $"Box: -";

            string mainBoardString;
            if (MainBoard != null)
                mainBoardString = $"\nMain Borad: \n\tName: {MainBoard.Name}; \n\tChipset: {MainBoard.Chipset};";
            else
                mainBoardString = $"\nMain Board: -";

            string processorString;
            if (Processor != null)
                processorString = $"\nProcessor: \n\tName: {Processor.Name}: \n\tFamily: {Processor.Family}; \n\tNumber of Cores: {Processor.NumOfCores};";
            else
                processorString = $"\nProcessor: -";

            string memoryString;
            if (Memory != null)
                memoryString = $"\nMemory: \n\tName: {Memory.Name}; \n\tVolume: {Memory.Volume} GB;";
            else
                memoryString = $"\nMemory: -";

            string hddString;
            if (Hdd != null)
                hddString = $"\nHdd: \n\tName: {Hdd.Name}: \n\tType: {Hdd.Type}; \n\tCapacity: {Hdd.Capacity} GB.";
            else
                hddString = $"\nHdd: -";

            return boxString +
                mainBoardString +
                processorString +
                memoryString +
                hddString;
        }
    }
}
