using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string dashes = "----------------------------------------------------------";
            WriteLine(dashes);
            WriteLine(
                format: "{0,-12} {1,-8} {2,9} {3,12}",
                "Type",
                "Byte(s) of Memory",
                "Min",
                "Max"
            );
            WriteLine(dashes);
            WriteLine(
                format: "{0,-12} {1,-8} {2,18} {3,12}",
                "sbyte",
                sizeof(sbyte),
                sbyte.MinValue,
                sbyte.MaxValue
            );
            WriteLine(
                format: "{0,-12} {1,-8} {2,18} {3,12}",
                "byte",
                sizeof(byte),
                byte.MinValue,
                byte.MaxValue
            );
            WriteLine(
                format: "{0,-12} {1,-8} {2,18} {3,12}",
                "short",
                sizeof(short),
                short.MinValue,
                short.MaxValue
            );
            WriteLine(
                format: "{0,-12} {1,-8} {2,18} {3,12}",
                "ushort",
                sizeof(ushort),
                ushort.MinValue,
                ushort.MaxValue
            );
            WriteLine(
                format: "{0,-12} {1,-8} {2,18} {3,12}",
                "int",
                sizeof(int),
                int.MinValue,
                int.MaxValue
            );
            WriteLine(
                format: "{0,-12} {1,-8} {2,18} {3,12}",
                "uint",
                sizeof(uint),
                uint.MinValue,
                uint.MaxValue
            );
            WriteLine(
                format: "{0,-12} {1,-8} {2,18} {3,12}",
                "long",
                sizeof(long),
                long.MinValue,
                long.MaxValue
            );
            WriteLine(
                format: "{0,-12} {1,-8} {2,18} {3,12}",
                "ulong",
                sizeof(ulong),
                ulong.MinValue,
                ulong.MaxValue
            );
            WriteLine(
                format: "{0,-12} {1,-8} {2,18} {3,12}",
                "float",
                sizeof(float),
                float.MinValue,
                float.MaxValue
            );
            WriteLine(
                format: "{0,-12} {1,-8} {2,18} {3,12}",
                "double",
                sizeof(double),
                double.MinValue,
                double.MaxValue
            );
            WriteLine(
                format: "{0,-12} {1,-8} {2,18} {3,12}",
                "decimal",
                sizeof(decimal),
                decimal.MinValue,
                decimal.MaxValue
            );
        }
    }
}
