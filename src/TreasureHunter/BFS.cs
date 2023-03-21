using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Tracing;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TreasureHunter;

namespace TreasureHunterAlgo
{
    public class BFS
    {
        private Maze m;
        private Node curNode;
        private List<Node> discovered;
        private Queue<Node> liveNode;
        public BFS()
        {
            m = new Maze();
            curNode = new Node();
            discovered = new List<Node> ();
            liveNode =  new Queue<Node> ();
        }
        public BFS(Maze m)
        {
            this.m = m;
            this.initializeStartingPoint(this.m.Start.i, this.m.Start.j);
        }
        public Node CurNode
        {
            get { return this.curNode; }
            set { this.curNode = value; }
        }
        /// <summary>
        /// Blah
        /// </summary>
        /// <param name="startI">The i index of the starting point</param>
        /// <param name="startJ">The j index of the starting point</param>
        public void initializeStartingPoint(int startI, int startJ)
        {
            curNode = new Node(startI, startJ);
            discovered = new List<Node> { curNode };
            liveNode = new Queue<Node>();
            Node upperNode = new Node(curNode.I - 1, curNode.J, curNode);
            Node rightNode = new Node(curNode.I, curNode.J + 1, curNode);
            Node bottomNode = new Node(curNode.I + 1, curNode.J, curNode);
            Node leftNode = new Node(curNode.I, curNode.J - 1, curNode);
            if (this.m.isIdxEff(curNode.I - 1, curNode.J) && this.m.Content[curNode.I - 1][curNode.J] != "X")
            {
                liveNode.Enqueue(upperNode);
            }
            if (this.m.isIdxEff(curNode.I, curNode.J + 1) && this.m.Content[curNode.I][curNode.J + 1] != "X")
            {
                liveNode.Enqueue(rightNode);
            }
            if (this.m.isIdxEff(curNode.I + 1, curNode.J) && this.m.Content[curNode.I + 1][curNode.J] != "X")
            {
                liveNode.Enqueue(bottomNode);
            }
            if (this.m.isIdxEff(curNode.I, curNode.J - 1) && this.m.Content[curNode.I][curNode.J - 1] != "X")
            {
                liveNode.Enqueue(leftNode);
            }
        }
        public void enqueueValidNode()
        {
            Node upperNode = new Node(curNode.I - 1, curNode.J, curNode);
            Node rightNode = new Node(curNode.I, curNode.J + 1, curNode);
            Node bottomNode = new Node(curNode.I + 1, curNode.J, curNode);
            Node leftNode = new Node(curNode.I, curNode.J - 1, curNode);
            if (this.m.isIdxEff(curNode.I - 1, curNode.J) && this.m.Content[curNode.I - 1][curNode.J] != "X" && !curNode.isBackTrack(curNode.I - 1, curNode.J) && !isDiscovered(upperNode, this.discovered))
            {
                liveNode.Enqueue(upperNode);
            }
            if (this.m.isIdxEff(curNode.I, curNode.J + 1) && this.m.Content[curNode.I][curNode.J + 1] != "X" && !curNode.isBackTrack(curNode.I, curNode.J + 1) && !isDiscovered(rightNode, this.discovered))
            {
                liveNode.Enqueue(rightNode);

            }
            if (this.m.isIdxEff(curNode.I + 1, curNode.J) && this.m.Content[curNode.I + 1][curNode.J] != "X" && !curNode.isBackTrack(curNode.I + 1, curNode.J) && !isDiscovered(bottomNode, this.discovered))
            {
                liveNode.Enqueue(bottomNode);
            }
            if (this.m.isIdxEff(curNode.I, curNode.J - 1) && this.m.Content[curNode.I][curNode.J - 1] != "X" && !curNode.isBackTrack(curNode.I, curNode.J - 1) && !isDiscovered(leftNode, this.discovered))
            {
                liveNode.Enqueue(leftNode);
            }
        }
        public Node doAction()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            while (this.liveNode.Count != 0)
            {
                Node tempNode = liveNode.Dequeue();
                if (!isDiscovered(tempNode, this.discovered))
                {
                    this.curNode = tempNode;
                    this.discovered.Add(tempNode);
                    if (this.m.Content[curNode.I][curNode.J] == "T" && !curNode.hasInPath(curNode.I, curNode.J))
                    {
                        this.curNode.TreasureFound++;
                    }
                    if (CurNode.TreasureFound == this.m.TreasureCount)
                    {
                        break;
                    }
                    enqueueValidNode();
                }
            }
            Node resultNode;
            if (CurNode.TreasureFound != this.m.TreasureCount)
            {
                int treasureFound = 0;
                resultNode = null;
                this.initializeStartingPoint(m.Start.i, m.Start.j);
                while (treasureFound != this.m.TreasureCount)
                {
                    while (true)
                    {
                        Node tempCurNode = liveNode.Dequeue();
                        if (!isDiscovered(tempCurNode, discovered))
                        {
                            CurNode = tempCurNode;
                            this.discovered.Add(tempCurNode);
                            if (this.m.Content[CurNode.I][CurNode.J] == "T")
                            {
                                treasureFound++;
                                this.m.Content[CurNode.I][CurNode.J] = "R";
                                resultNode = append(resultNode, CurNode, m);
                                this.initializeStartingPoint(CurNode.I, CurNode.J);
                                break;
                            }
                            enqueueValidNode();
                        }

                    }
                }
            }
            else
            {
                resultNode = new Node(curNode.I, curNode.J, curNode.Path, curNode.Route, curNode.TreasureFound);
            }
            this.initializeStartingPoint(resultNode.I, resultNode.J);
            while (this.liveNode.Count != 0)
            {
                Node tempNode = liveNode.Dequeue();
                if (!isDiscovered(tempNode, this.discovered))
                {
                    this.curNode = tempNode;
                    this.discovered.Add(tempNode);
                    if (this.m.Content[curNode.I][curNode.J] == "K")
                    {
                        break;
                    }
                    enqueueValidNode();
                }
            }
            resultNode = append(resultNode, curNode, this.m);
            return resultNode;

        }

        public static bool isDiscovered(Node n, List<Node> discoveredNodes)
        {
            foreach (var node in discoveredNodes)
            {
                if (node == n) return true;
            }
            return false;
        }

        public static Node append(Node a, Node b, Maze m)
        {
            if (a == null || (a.I == -1 && a.J == -1))
            {
                return b;
            }
            else
            {
                foreach (var node in b.Path)
                {
                    if (m.Content[node.i][node.j] == "T" && !a.hasInPath(node.i, node.j))
                    {
                        a.TreasureFound++;
                    }
                    a.Path.Add(node);
                }
                if (m.Content[b.I][b.J] == "T" && !a.hasInPath(b.I, b.J))
                {
                    a.TreasureFound++;
                }
                int iDiff = b.Path[0].i - a.I;
                int jDiff = b.Path[0].j - a.J;
                if (iDiff == -1 && jDiff == 0) { a.Route.Add("U"); }
                else if (iDiff == 0 && jDiff == 1) { a.Route.Add("R"); }
                else if (iDiff == 1 && jDiff == 0) { a.Route.Add("D"); }
                else if (iDiff == 0 && jDiff == -1) { a.Route.Add("L"); }
                foreach (var r in b.Route)
                {
                    a.Route.Add(r);
                }
                a.I = b.I;
                a.J = b.J;
                return a;
            }
        }
        
    }
}
