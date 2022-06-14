using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerStore;

namespace Lab3NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembler assembler = new Assembler();
            SystemUnitBuilder builder = new IntelSysUnitBuilder();

            SystemUnit intelSysUnit = assembler.Assemble(builder);
            Console.WriteLine("Intel System Unit:\n" + intelSysUnit);

            Console.WriteLine("\n");

            builder = new AMDSysUnitBuilder();
            SystemUnit amdSysUnit = assembler.Assemble(builder);
            Console.WriteLine("AMD System Unit:\n" + amdSysUnit);
        }
    }
}
