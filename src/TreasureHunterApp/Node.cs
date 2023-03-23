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
        private List<string> route;
        private int treasureFound;

        public Node()
        {
            i = 0;
            j = 0;
            path = new List<(int i, int j)>();
            route = new List<string>();
            treasureFound = 0;
        }
        public Node(int i, int j)
        {
            this.i = i;
            this.j = j;
            path = new List<(int i, int j)>();
            route = new List<string>();
            treasureFound = 0;
        }
        public Node(int i, int j, Node other)
        {
            this.i = i;
            this.j = j;
            route = new List<string>();
            foreach (var item in other.Route)
            {
                this.route.Add(item);
            }
            int iDiff = this.i - other.i;
            int jDiff = this.j - other.j;
            if (iDiff == -1 && jDiff == 0) { this.route.Add("U"); }
            else if (iDiff == 0 && jDiff == 1) { this.route.Add("R"); }
            else if (iDiff == 1 && jDiff == 0) { this.route.Add("D"); }
            else if (iDiff == 0 && jDiff == -1) { this.route.Add("L"); }
            else if (iDiff == 0 && jDiff == 0) { this.route.Add("S"); }
            this.path = new List<(int i, int j)>();
            foreach (var cell in other.Path)
            {
                this.path.Add(cell);
            }
            this.path.Add((other.I, other.J));
            this.treasureFound = other.treasureFound;
        }
        public Node(int i, int j, List<(int i, int j)> path, List<string> route, int treasureFound) : this(i, j, path)
        {
            this.route = route;
            this.treasureFound = treasureFound;
            I = i;
            J = j;
            Path = path;
            TreasureFound = treasureFound;
            Route = route;
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
        public int TreasureFound { get { return treasureFound; } set { treasureFound = value; } }
        public List<string> Route { get { return route; } set { route = value; } }
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

        public bool isBackTrack(int i, int j)
        {
            if (this.Path.Count == 0)
            {
                return false;
            }
            else
            {
                return this.Path[this.Path.Count - 1] == (i, j);
            }
        }

        public bool isSubsetOf(Node other)
        {
            List<(int i, int j)> thisPath = this.Path.ConvertAll(x => x);
            List<(int i, int j)> otherPath = other.Path.ConvertAll(x => x);
            thisPath.Add((this.I, this.J));
            otherPath.Add((other.I, other.J));
            for (int i = 0; i < thisPath.Count; i++)
            {
                if (thisPath[i] != otherPath[i])
                {
                    return false;
                }
            }
            return true;
        }
        public int countTileOccurence(int i, int j)
        {
            int occ = 0;
            foreach (var tile in this.Path)
            {
                if (tile == (i, j))
                {
                    occ++;
                }
            }
            if (this.I == i && this.J == j)
            {
                occ++;
            }
            return occ;
        }
    }
}
