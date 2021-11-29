using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTask
{

    public class MessageDec
    {
        public string path { get; set; }
        public string initial { get; set; }

        public void decodeMessage(string path, string initial)
        {

            var filepath = Path.Combine(Directory.GetCurrentDirectory(), path);
            var lines = File.ReadAllText(filepath);

            int counter = 0;
            StreamReader file = new StreamReader(filepath);

            while ((lines = file.ReadLine()) != null)
            {
                if (lines.Contains(initial))
                {
                    var msg = lines.ElementAt(4);
                    Console.WriteLine(msg);
                    var revstring = lines.Reverse().Take(3).ToArray();

                }


                counter++;
            }



            file.Close();
            Console.ReadKey();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            MessageDec md = new MessageDec();
            md.decodeMessage("EncodedMessage.txt", "QVH");
        }
    }

}
