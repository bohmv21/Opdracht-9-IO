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
            string strPath = "../";


            int intCount = 1;
            var msg = File.ReadAllLines(strFileName);
            int intAmountOfDocs = 1000;

            string strMsg = File.ReadAllText(strCMD);
            Console.WriteLine(strMsg);

            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");


            int beep = 1000;

            do
            {
                Console.Beep(beep , 50);
                beep = beep + 50;
                if (beep >= 13000)
                {
                    do
                    {
                        Console.Beep(beep, 50);
                        beep = beep - 50;
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



            //Dit is voor loop1, er moet nog een 2e loop gemaakt worden die alleen activeert zodra dat de files al bestaan.
                do
                {
                    File.WriteAllLines(strPath + intCount + ".txt", msg);
                    intCount++;

                } while (intCount < intAmountOfDocs);
            }
        }
    }

