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
            string strTextPath = @"C:\Users\bohmv\Documents\ICT shit\Visual Studio\Opdracht 9 IO\Opdracht 9 IO\bin\Debug\Recources\";
            string strPath = @"C:\Users\bohmv\Documents\ICT shit\Visual Studio\Opdracht 9 IO\Opdracht 9 IO\Text spam\";
            //string strInput = "Dit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regelDit is tekst uit bestand op regel ";


            int intCount = 0;
            var msg = File.ReadAllLines(strFileName);
            Console.WriteLine("Content uit een bestand : " + strPath + strFileName);
            Console.WriteLine("Hoeveel lines wilt u displayen");
            int intLines = 95;
            // Convert.ToInt16(Console.ReadLine());
            string strMsg = File.ReadAllText(strCMD);
            Console.WriteLine(strMsg);

            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
            //
            do
            {
                intCount++;
                File.WriteAllLines(strPath + intCount + ".txt", msg);

            } while (intCount < intLines);
        }
    }
}
