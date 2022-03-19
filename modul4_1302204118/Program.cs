using System;
using System.Collections.Generic;

namespace mod4_1302204118
{
    class Program
    {
        static void Main(string[] args)
    {
        
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<int>(12, 34, 56));

        
    }
}

class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T input1, T input2, T input3)
    {
        dynamic a = input1;
        dynamic b = input2;
        dynamic c = input3;

        return a + b + c;

        
    }
}


}