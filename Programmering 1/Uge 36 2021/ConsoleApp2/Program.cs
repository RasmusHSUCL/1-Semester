using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 255;
            sbyte z = 126;
            ushort y = 65535;
            short Y = 32767; // 0111 1111 1111 1111
            
            int saldoAarTilDato = 2147483647; // 01111 1111 1111 1111 1111 1111 1111 1111
            int saldo = -2147483647; // 32 bit
            
            long langTal = 0; // 64 bit
            ulong ulangTal2 = 90;
            
            double decTal = 3.14; // decimaltal

            // 1000 0000 0000 0000 0000 0000 0000 0000
            x++;
        }
    }
}
