using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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
            curNode = new Node(m.Start.i, m.Start.j);
            discovered = new List<Node> { curNode };
            liveNode = new Queue<Node> ();
            if (this.m.isIdxEff(curNode.I - 1, curNode.J))
            {
                if (this.m.Content[curNode.I - 1][curNode.J] != "X")
                {
                    Node upperNode = new Node(curNode.I - 1, curNode.J, curNode);
                    liveNode.Enqueue(upperNode);
                }
            }
            if (this.m.isIdxEff(curNode.I, curNode.J + 1))
            {
                if (this.m.Content[curNode.I][curNode.J + 1] != "X")
                {
                    Node upperNode = new Node(curNode.I, curNode.J + 1, curNode);
                    liveNode.Enqueue(upperNode);
                }
            }
            if (this.m.isIdxEff(curNode.I + 1, curNode.J))
            {
                if (this.m.Content[curNode.I + 1][curNode.J] != "X")
                {
                    Node upperNode = new Node(curNode.I + 1, curNode.J, curNode);
                    liveNode.Enqueue(upperNode);
                }
            }
            if (this.m.isIdxEff(curNode.I, curNode.J - 1))
            {
                if (this.m.Content[curNode.I][curNode.J - 1] != "X")
                {
                    Node upperNode = new Node(curNode.I, curNode.J - 1, curNode);
                    liveNode.Enqueue(upperNode);
                }
            }
        }
        public Node CurNode
        {
            get { return this.curNode; }
            set { this.curNode = value; }
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
                    Node upperNode = new Node(curNode.I - 1, curNode.J, curNode);
                    Node rightNode = new Node(curNode.I, curNode.J + 1, curNode);
                    Node bottomNode = new Node(curNode.I + 1, curNode.J, curNode);
                    Node leftNode = new Node(curNode.I, curNode.J - 1, curNode);
                    if (this.m.isIdxEff(curNode.I - 1, curNode.J) && this.m.Content[curNode.I - 1][curNode.J] != "X" && curNode.Path[curNode.Path.Count - 1] != (curNode.I - 1, curNode.J) && !isDiscovered(upperNode, this.discovered))
                    {
                        liveNode.Enqueue(upperNode);
                    }
                    if (this.m.isIdxEff(curNode.I, curNode.J + 1) && this.m.Content[curNode.I][curNode.J + 1] != "X" && curNode.Path[curNode.Path.Count - 1] != (curNode.I, curNode.J + 1) && !isDiscovered(rightNode, this.discovered))
                    { 
                        liveNode.Enqueue(rightNode);
                            
                    }
                    if (this.m.isIdxEff(curNode.I + 1, curNode.J) && this.m.Content[curNode.I + 1][curNode.J] != "X" && curNode.Path[curNode.Path.Count - 1] != (curNode.I + 1, curNode.J) && !isDiscovered(bottomNode, this.discovered))
                    {
                        liveNode.Enqueue(bottomNode);
                    }
                    if (this.m.isIdxEff(curNode.I, curNode.J - 1) && this.m.Content[curNode.I][curNode.J - 1] != "X" && curNode.Path[curNode.Path.Count - 1] != (curNode.I, curNode.J - 1) && !isDiscovered(leftNode, this.discovered))
                    {
                        liveNode.Enqueue(leftNode);
                    }
                }
            }
            if (CurNode.TreasureFound != this.m.TreasureCount)
            {
                watch.Stop();
                var newWatch = new System.Diagnostics.Stopwatch();
                newWatch.Start();
                int treasureFound = 0;
                Node resultNode = null;
                curNode = new Node(m.Start.i, m.Start.j);
                discovered = new List<Node> { curNode };
                liveNode = new Queue<Node>();
                if (this.m.isIdxEff(curNode.I - 1, curNode.J) && this.m.Content[curNode.I - 1][curNode.J] != "X")
                {
                    Node upperNode = new Node(curNode.I - 1, curNode.J, curNode);
                    liveNode.Enqueue(upperNode);
                }
                if (this.m.isIdxEff(curNode.I, curNode.J + 1) && this.m.Content[curNode.I][curNode.J + 1] != "X")
                {
                    Node upperNode = new Node(curNode.I, curNode.J + 1, curNode);
                    liveNode.Enqueue(upperNode);
                }
                if (this.m.isIdxEff(curNode.I + 1, curNode.J) && this.m.Content[curNode.I + 1][curNode.J] != "X")
                {
                    Node upperNode = new Node(curNode.I + 1, curNode.J, curNode);
                    liveNode.Enqueue(upperNode);
                }
                if (this.m.isIdxEff(curNode.I, curNode.J - 1) && this.m.Content[curNode.I][curNode.J - 1] != "X")
                {
                    Node upperNode = new Node(curNode.I, curNode.J - 1, curNode);
                    liveNode.Enqueue(upperNode);
                }
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
                                curNode = new Node(CurNode.I, CurNode.J);
                                discovered = new List<Node> { curNode };
                                liveNode = new Queue<Node>();
                                if (this.m.isIdxEff(curNode.I - 1, curNode.J) && this.m.Content[curNode.I - 1][curNode.J] != "X")
                                {
                                    Node nodeToAdd = new Node(curNode.I - 1, curNode.J, curNode);
                                    liveNode.Enqueue(nodeToAdd);
                                }
                                if (this.m.isIdxEff(curNode.I, curNode.J + 1) && this.m.Content[curNode.I][curNode.J + 1] != "X")
                                {
                                    Node nodeToAdd = new Node(curNode.I, curNode.J + 1, curNode);
                                    liveNode.Enqueue(nodeToAdd);
                                }
                                if (this.m.isIdxEff(curNode.I + 1, curNode.J) && this.m.Content[curNode.I + 1][curNode.J] != "X")
                                {
                                    Node nodeToAdd = new Node(curNode.I + 1, curNode.J, curNode);
                                    liveNode.Enqueue(nodeToAdd);
                                }
                                if (this.m.isIdxEff(curNode.I, curNode.J - 1) && this.m.Content[curNode.I][curNode.J - 1] != "X")
                                {
                                    Node nodeToAdd = new Node(curNode.I, curNode.J - 1, curNode);
                                    liveNode.Enqueue(nodeToAdd);
                                }
                                break;
                            }
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

                    }
                }
                newWatch.Stop();
                System.Console.WriteLine($"Execution Time: {newWatch.Elapsed.TotalSeconds * 1000000} ms");
                return resultNode;
            }
            else
            {
                watch.Stop();
                System.Console.WriteLine($"Execution Time: {watch.Elapsed.TotalSeconds * 1000000} ms");
                return CurNode;
            }
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
                int iDiff = a.I - b.I;
                int jDiff = a.J - b.J;
                if (iDiff == -1 && jDiff == 0) { a.Route.Add("U"); }
                else if (iDiff == 0 && jDiff == 1) { a.Route.Add("R"); }
                else if (iDiff == 1 && jDiff == 0) { a.Route.Add("D"); }
                else if (iDiff == 0 && jDiff == -1) { a.Route.Add("L"); }
                else if (iDiff == 0 && jDiff == 0) { a.Route.Add("S"); }
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
