using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureHunterAlgo
{
    public class Maze
    {
        private List<List<string>> content;
        private (int i, int j) start;
        private int length;
        private int width;
        private int treasureCount;
        private bool valid;
        public Maze()
        {
            content = new List<List<string>>();
            start = (0, 0);
            length = 0;
            width = 0;
            treasureCount = 0;
            valid = false;
        }
        public Maze(string txtFile)
        {
            var lines = File.ReadAllLines(txtFile);
            content = new List<List<string>>();
            treasureCount = 0;
            this.valid = true;
            foreach (var line in lines)
            {
                string[] curLine = line.Split(' ');
                List<string> characters = new List<string>();
                foreach (var info in curLine)
                {
                    if (info == "T")
                    {
                        this.treasureCount++;
                    }
                    else if (info != "T" && info != "K" && info != "R" && info != "X")
                    {
                        this.valid = false;
                    }
                    characters.Add(info);
                }
                content.Add(characters);
            }

            this.width = lines.Length;
            this.length = (this.content)[0].Count();

            int startN = 0, startM = 0;
            bool found = false;
            foreach (var column in content)
            {
                startM = 0;
                foreach (var info in column)
                {
                    if (info == "K")
                    {
                        found = true;
                        break;
                    }
                    startM++;
                }
                if (found)
                {
                    break;
                }
                startN++;
            }

            this.start = (startN, startM);
        }

        public List<List<string>> Content
        {
            get { return content; }
            set { content = value; }
        }
        public (int i, int j) Start
        {
            get { return start; }
            set { start = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int TreasureCount
        {
            get { return treasureCount; }
            set { treasureCount = value; }
        }
        public bool Valid
        {
            get { return valid; }
            set { valid = value; }
        }

        public bool isIdxEff(int i, int j)
        {
            return (i >= 0 && j >= 0 && i < this.width && j < this.length);
        }

        public int countWhiteTiles()
        {
            int count = 0;
            foreach (var rows in this.Content)
            {
                foreach (var character in rows)
                {
                    if (character == "K" || character == "R" || character == "T")
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
