using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class FileHandler 
    {
        private static readonly DateTime programStartTime = DateTime.Now;

        public string path = @"../../../logs";
        public string filename => $"{programStartTime:dd-MM-yy HH-mm-ss}.txt";
        public void CreateFile()
        {
            StreamWriter outputStream = File.CreateText($@"{path}/{filename}");
            outputStream.Close();
        }
        public List<string> ReadFile()
        {
            List<string> lines = File.ReadLines($@"{path}/{filename}").ToList();
            return lines;
        }
    }
}
