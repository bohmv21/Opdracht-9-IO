using System;
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
            int intAmountOfDocs = 1000;
            // Convert.ToInt16(Console.ReadLine());
            string strMsg = File.ReadAllText(strCMD);
            Console.WriteLine(strMsg);

            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
            //Piepjescode
            /*
            int beep = 50;

            do
            {
                Console.Beep(beep , 100);
                beep = beep + 100;
                if (beep >= 13000)
                {
                    do
                    {
                        Console.Beep(beep, 100);
                        beep = beep - 100;
                    } while (beep >= 150);
                }
            } while (true);
            */

            if (!File.Exists("filecheck.dat"))
            {
                    File.WriteAllText("filecheck.dat", "1");
            }


            string strFileCheck = File.ReadAllLines("filecheck.dat").Last();
            int intFileCheck = Convert.ToInt32(strFileCheck);
            intFileCheck += intAmountOfDocs;
            if (intFileCheck < intAmountOfDocs-1)
            {

            }
            else
            {
                intAmountOfDocs = intFileCheck;
            }
            File.WriteAllText("filecheck.dat", Convert.ToString(intAmountOfDocs));
            Console.ReadLine();



            //Dit is voor loop1, er moet nog een 2e loop gemaakt worden die alleen activeert zodra dat de files al bestaan.
                do
                {
                    File.WriteAllLines(strPath + intCount + ".txt", msg);
                    intCount++;

                } while (intCount < intAmountOfDocs);
            }
        }
    }

