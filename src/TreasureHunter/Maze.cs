using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureHunterAlgo
{
    public class Maze
    {
        List<List<string>> content;
        (int i, int j) start;
        public Maze() 
        {
            content = new List<List<string>>();
            start = (0, 0);
        }
        public Maze(string txtFile)
        {
            var lines = File.ReadAllLines(txtFile);
            content = new List<List<string>>();
            foreach (var line in lines)
            {
                string[] curLine = line.Split(' ');
                List<string> strings = new List<string>();
                foreach (var info in curLine)
                {
                    strings.Add(info);
                }
                content.Add(strings);
            }

            int startN = 0, startM = 0;
            foreach (var column in content)
            {
                startM = 0;
                foreach (var info in column)
                {
                    if (info == "S")
                    {
                        break;
                    }
                    startM++;
                }
                startN++;
            }

            this.start = (startN, startM);
        }

    }
}
