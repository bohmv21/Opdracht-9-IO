﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Opdracht_9_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            string strFileName = "data.txt";
            string strCMD = "Ms.txt";
            //string strTextPath = @"C:\Users\bohmv\Documents\ICT shit\Visual Studio\Opdracht 9 IO\Opdracht 9 IO\bin\Debug\Recources\";
            string strPath = "../";
            //string strInput = "Dit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regel ";


            int intCount = 1;
            var msg = File.ReadAllLines(strFileName);
            Console.WriteLine("Content uit een bestand : " + strPath + strFileName);
            Console.WriteLine("Hoeveel lines wilt u displayen");
            int intAmountOfDocs = 100;
            // Convert.ToInt16(Console.ReadLine());
            string strMsg = File.ReadAllText(strCMD);
            Console.WriteLine(strMsg);

            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");


            //Dit is voor loop1, er moet nog een 2e loop gemaakt worden die alleen activeert zodra dat de files al bestaan.
            if (!File.Exists(strPath + intCount + ".txt"))
            {
                do
                {
                    File.WriteAllLines(strPath + intCount + ".txt", msg);
                    intCount++;

                } while (intCount < intAmountOfDocs);
            }
            else if (File.Exists(strPath + intCount+1 + ".txt"))
            {
                intAmountOfDocs += 100;
                intCount += 100;
                do
                {
                    File.WriteAllLines(strPath + intCount + ".txt", msg);
                    intCount++;

                } while (intCount < intAmountOfDocs);
            }
        }
    }
}
