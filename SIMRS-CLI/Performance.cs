using System;
using System.Collections.Generic;
using System.Diagnostics;
using Internal;
using SIMRS_CLI.Models;
using SIMRS_LIB;

namespace SIMRS_CLI
{
    public class Performance
    {
        public class Data
        {
            public int id { get; set; }
            public string name { get; set; }
            public int age { get; set; }
            public string email { get; set; }
            public string address { get; set; }
        }

        public class RootObject
        {
            public List<Data> data { get; set; }
        }

        public static void PerformanceTest()
        {
            Stopwatch stopwatch1 = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            List<List<Data>> listdataarray = new List<List<Data>>();

            RootObject defaultData = JsonUtils<RootObject>.ReadJsonFromFile(@"../../../../SIMRS-CLI/Json/PerformanceTest.json");

            stopwatch1.Start();
            for (int i = 0; i < 1000; i++)
            {
                List<Data> listdata = new List<Data>();
                foreach (Data a in defaultData.data)
                {
                    listdata.Add(a);
                }
                listdataarray.Add(listdata);
            }
            stopwatch1.Stop();

            stopwatch2.Start();
            foreach (List<Data> a in listdataarray)
            {
                foreach (Data b in a)
                {
                    Console.WriteLine(b.name);
                }
            }
            stopwatch2.Stop();

            Console.WriteLine($"Waktu menyimpan data: {stopwatch1.ElapsedMilliseconds} ms");

            Console.WriteLine($"Waktu mengoutputkan data: {stopwatch2.ElapsedMilliseconds} ms");
        }
    }
}

