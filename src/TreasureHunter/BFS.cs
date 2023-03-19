using System.Collections.Generic;
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
        public void doAction()
        {
            // Cell priority {up, right, down, left}
            while (this.curNode.TreasureFound != this.m.TreasureCount)
            {
                if (this.liveNode.Count != 0)
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
                        Node upperNode = new Node(curNode.I - 1, curNode.J, curNode);
                        Node rightNode = new Node(curNode.I, curNode.J + 1, curNode);
                        Node bottomNode = new Node(curNode.I + 1, curNode.J, curNode);
                        Node leftNode = new Node(curNode.I, curNode.J - 1, curNode);
                        if (this.m.isIdxEff(curNode.I - 1, curNode.J))
                        {
                            if (this.m.Content[curNode.I - 1][curNode.J] != "X" && !curNode.hasInPath(curNode.I - 1, curNode.J) && !isDiscovered(upperNode, discovered))
                            {
                                liveNode.Enqueue(upperNode);
                            }
                        }
                        if (this.m.isIdxEff(curNode.I, curNode.J + 1))
                        {
                            if (this.m.Content[curNode.I][curNode.J + 1] != "X" && !curNode.hasInPath(curNode.I, curNode.J + 1) && !isDiscovered(rightNode, discovered))
                            {
                                liveNode.Enqueue(rightNode);
                            }
                        }
                        if (this.m.isIdxEff(curNode.I + 1, curNode.J))
                        {
                            if (this.m.Content[curNode.I + 1][curNode.J] != "X" && !curNode.hasInPath(curNode.I + 1, curNode.J) && !isDiscovered(bottomNode, discovered))
                            {
                                liveNode.Enqueue(bottomNode);
                            }
                        }
                        if (this.m.isIdxEff(curNode.I, curNode.J - 1))
                        {
                            if (this.m.Content[curNode.I][curNode.J - 1] != "X" && !curNode.hasInPath(curNode.I, curNode.J - 1) && !isDiscovered(leftNode, discovered))
                            {
                                liveNode.Enqueue(leftNode);
                            }
                        }
                    }
                }
                else
                {
                    curNode = new Node(curNode.I, curNode.J, curNode);
                    discovered = new List<Node> { curNode };
                    liveNode = new Queue<Node>();
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
            }
            // if (curNode.TreasureFound < this.m.TreasureCount)
            // {
            // 
            // }
        }

        public static bool isDiscovered(Node n, List<Node> discoveredNodes)
        {
            foreach (var node in discoveredNodes)
            {
                if (node == n) return true;
            }
            return false;
        }
        
    }
}
