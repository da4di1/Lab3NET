using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    public class Assembler
    {
        public SystemUnit Assemble(SystemUnitBuilder builder)
        {
            builder.CreateSysUnit();
            builder.SetBox();
            builder.SetMainBoard();
            builder.SetProcessor();
            builder.SetMemory();
            builder.SetHdd();

            return builder.SystemUnit;
        }
    }
}
