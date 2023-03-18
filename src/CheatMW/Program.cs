using CheatMW.Speed;
using Memory;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;


class Program
{
    public static string procName = "speed";
    static void Main()
    {
        try
        {
            Mem m = new Mem();



            bool openProc = false;

            openProc = m.OpenProcess(procName);

            if (openProc)
            {

                int cash = m.ReadInt(MWAddresses.GameStats.GAME_CASH);
                Console.WriteLine(cash);

                m.WriteMemory(MWAddresses.GameStats.GAME_CASH, "int", "454");
                m.WriteMemory(MWAddresses.GameStats.GAME_NAME, "string", "FUCK@");


            }
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }
}
