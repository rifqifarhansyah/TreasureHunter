using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureHunterAlgo
{
    public class Node
    {
        private int i;
        private int j;
        private List<(int i, int j)> path;

        public Node()
        {
            i = 0;
            j = 0;
            path = new List<(int i, int j)>();
        }
        public Node(int i, int j)
        {
            this.i = i;
            this.j = j;
            path = new List<(int i, int j)>();
        }
        public Node(int i, int j, Node other)
        {
            this.i = i;
            this.j = j;
            this.path = other.Path;
            this.path.Add((other.I, other.J));
        }
        public Node(int i, int j, List<(int i, int j)> path)
        {
            this.i = i;
            this.j = j;
            this.path = path;
        }
        public int I { get { return i; } set { i = value; } }
        public int J { get { return j; } set { j = value; } }
        public List<(int i, int j)> Path { get { return path; } set { path = value; } }
    }
}
