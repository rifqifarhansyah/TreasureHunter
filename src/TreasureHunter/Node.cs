using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreasureHunterAlgo
{
    public class Node
    {
        private int i;
        private int j;
        private List<(int i, int j)> path;
        private int treasureFound;

        public Node()
        {
            i = 0;
            j = 0;
            path = new List<(int i, int j)>();
            treasureFound = 0;
        }
        public Node(int i, int j)
        {
            this.i = i;
            this.j = j;
            path = new List<(int i, int j)>();
            treasureFound = 0;
        }
        public Node(int i,int j,int cntTreasure)
        {
            this.i = i;
            this.j = j;
            this.treasureFound = cntTreasure;
        }
        public Node(int i, int j, Node other,int cntTreasure)
        {
            this.i = i;
            this.j = j;
            this.treasureFound=cntTreasure;
            this.path = new List<(int i, int j)>();
            foreach (var cell in other.Path)
            {
                this.path.Add(cell);
            }
            this.path.Add((other.I, other.J));
            this.treasureFound = other.treasureFound;
        }
        public Node(int i, int j, Node other)
        {
            this.i = i;
            this.j = j;
            this.path = new List<(int i, int j)>();
            foreach (var cell in other.Path)
            {
                this.path.Add(cell);
            }
            this.path.Add((other.I, other.J));
            this.treasureFound = other.treasureFound;
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
        public int TreasureFound { get {  return treasureFound; } set {  treasureFound = value; } }
        public bool hasInPath(int i, int j)
        {
            foreach (var coor in path)
            {
                if ((i, j) == coor)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
