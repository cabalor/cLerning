﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Data
    {
        static void Main(String[] args)
        {

            DateTime date = new DateTime();
            var date2 = new DateTime(2015, 9, 25);
            var now = DateTime.Now;
            var today = DateTime.Today;


            Console.WriteLine("godzina " + now.Hour);
            Console.WriteLine("godzina " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());

            Console.WriteLine(now.ToString("yy-MM--dd"));

            Console.WriteLine("-------------time------------");

            TimeSpan span = new TimeSpan(1, 2, 3);
            var timespan = new TimeSpan(1,0,0);
            var timespan2 = TimeSpan.FromHours(1);

            var sta = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - sta;

            Console.WriteLine("dur " + duration);

            Console.WriteLine("Minutes "+ timespan.Minutes);
            Console.WriteLine("total minutes "+timespan.TotalMinutes);

            Console.WriteLine("Add ex: "+ timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("sub ex: " + timespan.Subtract(TimeSpan.FromMinutes(8)));

            Console.WriteLine(timespan.ToString());

            Console.WriteLine(TimeSpan.Parse("01:33:45"));

            var test = "testowy ";
            Console.WriteLine(test.Trim());

            var index = test.IndexOf(" ");


            var zdanie = "dddd ddddd dddd zdanie ddd d dddd dddd zdanie";
            const int max = 15;
            int wyrazyLiterowe = 0;
            var listka = new List<string>();
            if (zdanie.Length < max)
            {
                Console.WriteLine("short");
            } else
            {
                Console.WriteLine("long");
                String[] words = zdanie.Split(' ');
                foreach(string w in words)
                {
                    wyrazyLiterowe += w.Length + 1;
                    listka.Add(w);
                }

            }

            Console.WriteLine(wyrazyLiterowe + " wyrazy literowe");


            StringBuilder sb = new StringBuilder();

            sb.Append('-', 10).AppendLine().Append("dupa").AppendLine();
          
            sb.Replace('-','*');
            Console.WriteLine(sb);

            Console.WriteLine(sb[4]);



            File.Copy(@"c:\temp\plik.jpg", @"d:\temp\plik"); //without @ "d:\\temp\\plik"

            var path = @"c:\tralala.jpg";

            File.Delete(path);

            if (File.Exists(path))
            {
                Console.WriteLine("jestem,");
            }

            FileInfo info = new FileInfo(path);

            info.CopyTo("...");

            if (info.Exists)
            {
                Console.WriteLine("jestem");
            }
            info.Delete();

        }


    }
}
