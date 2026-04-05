using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace ConsoleApp1
{
    class Indicator
    {
        public string id { get; set; }
        public string value { get; set; }
    }
    class Country
    {
        public string id { get; set; }
        public string value { get; set; }
    }
    class Population
    {
        public Indicator indicator { get; set; }
        public Country country { get; set; }
        public string value { get; set; }
        public string _decimal { get; set; } = string.Empty;
        public string date { get; set; }

        public override string ToString()
        {
            return indicator.value + " " + value + " " + country.value + " " + _decimal;
        }
    }


    class Program
    {
        private static void Main(string[] args)
        {
            // Zadanie 1

            //================================================================
            //using(StreamWriter writetext = new StreamWriter("text.txt"))
            //{
            //    writetext.WriteLine("Danila Chystikin, Nr albumu: 71424");
            //}
            //================================================================

            //try
            //{
            //    StreamWriter sw = new StreamWriter(@"path");
            //    sw.WriteLine("Danila Chystikin, ");
            //    sw.WriteLine("Nr albumu: 71424");
            //    sw.Close();
            //}    
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            // Zadanie 2
            //String line;
            //try
            //{
            //    StreamReader sr = new StreamReader(@"path");
            //    line = sr.ReadLine();

            //    while (line != null)
            //    {
            //        Console.WriteLine(line);
            //        line = sr.ReadLine();
            //    }

            //    sr.Close();
            //    Console.ReadLine();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // Zadanie 3
            //string path = @"path";

            //string[] lines = File.ReadAllLines(path + "pesels.txt");

            //int i = 1;

            //foreach (string line in lines)
            //{
            //    if (line.Length > 10)
            //    {
            //        int digit = line[9] - '0';

            //        if (digit % 2 == 0)
            //            Console.WriteLine($"{i}. {line} - Woman");
            //        else
            //            Console.WriteLine($"{i}. {line} - Man");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i}. {line} - The pesel is too short");
            //    }

            //    i++;
            //}

            // Zadanie 4
            //List<Population> population = new List<Population>();

            //string jsonString = File.ReadAllText(db.json);

            string json = File.ReadAllText("db.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            List<Population> date = JsonSerializer.Deserialize<List<Population>>(json, options);

            foreach (var a in date)
            {
                Console.Write(a.ToString());
                Console.WriteLine();
            }

            long pop1970 = 0;
            long pop2000 = 0;

            foreach (var a in date)
            {
                if (a.country.value == "India" && a.date == "1970")
                    pop1970 = long.Parse(a.value);
                if (a.country.value == "India" && a.date == "2000")
                    pop2000 = long.Parse(a.value);
            }

            Console.WriteLine("2000" + pop2000);
            Console.WriteLine("1970" + pop1970);
        }
    }
}
