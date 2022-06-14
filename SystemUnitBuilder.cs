using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    public abstract class SystemUnitBuilder
    {
        public SystemUnit SystemUnit { get; set; }


        public void CreateSysUnit()
        {
            SystemUnit = new SystemUnit();
        }

        public abstract void SetBox();
        public abstract void SetProcessor();
        public abstract void SetMainBoard();
        public abstract void SetHdd();
        public abstract void SetMemory();
    }
}
