using System;

class Program
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        uint mask = (1 << 3);
        uint bit3 = (number & mask) >> 3;
        mask = 1 << 24;
        uint bit24 = (number & mask) >> 24;
        //part2
        uint mask1 = 1 << 4;
        uint bit4 = (number & mask1) >> 4;
        mask1 = 1 << 25;
        uint bit25 = (number & mask1) >> 25;
        //part3
        uint mask2 = 1 << 5;
        uint bit5 = (number & mask2) >> 5;
        mask2 = 1 << 26;
        uint bit26 = (number & mask) >> 26;
        //logic
        uint  invertetmask = ~(((uint)1 << 3) | ((uint)1 << 4) | ((uint)1 << 4) | ((uint)1 << 23) | ((uint)1 << 24) | ((uint)1 << 25));
        number = number & invertetmask;
        uint farbits = (bit24 << 3) | (bit25 << 4) | (bit26 << 5);
        number = number | farbits;
        uint closebits = (bit3 << 24) | (bit4 << 25) | (bit5 << 26);
        number = number | closebits;
        Console.WriteLine(number);
    }
}
