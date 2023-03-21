using System;
using System.Collections.Generic;
using System.Text;

namespace TreasureHunterAlgo
{
    public class DFS
    {
        private Maze m;
        private Node curNode;
        private List<Node> discovered;
        private Stack<Node> liveNode;

        public Maze M { get => m; set => m = value; }
        public Node CurNode { get => curNode; set => curNode = value; }
        public List<Node> Discovered { get => discovered; set => discovered = value; }

        private List<(int i, int j)> discover;
        public Stack<Node> LiveNode { get => liveNode; set => liveNode = value; }

        public DFS()
        {
            M = new Maze();
            CurNode = new Node();
            discovered = new List<Node>();
            liveNode = new Stack<Node>();
        }
        public DFS(Maze m)
        {
            M = m;
            CurNode = new Node(m.Start.i, m.Start.j);
            discovered = new List<Node> { curNode };
            liveNode = new Stack<Node>();
            if (this.m.isIdxEff(curNode.I, curNode.J - 1))
            {
                if (this.m.Content[curNode.I][curNode.J - 1] != "X")
                {
                    Node upperNode = new Node(curNode.I, curNode.J - 1, curNode);
                    liveNode.Push(upperNode);
                }
            }
            if (this.m.isIdxEff(curNode.I + 1, curNode.J))
            {
                if (this.m.Content[curNode.I + 1][curNode.J] != "X")
                {
                    Node upperNode = new Node(curNode.I + 1, curNode.J, curNode);
                    liveNode.Push(upperNode);
                }
            }
            if (this.m.isIdxEff(curNode.I, curNode.J + 1))
            {
                if (this.m.Content[curNode.I][curNode.J + 1] != "X")
                {
                    Node upperNode = new Node(curNode.I, curNode.J + 1, curNode);
                    liveNode.Push(upperNode);
                }
            }
            if (this.m.isIdxEff(curNode.I - 1, curNode.J))
            {
                if (this.m.Content[curNode.I - 1][curNode.J] != "X")
                {
                    Node upperNode = new Node(curNode.I - 1, curNode.J, curNode);
                    liveNode.Push(upperNode);
                }
            }
            
            
            
        }

       

        public void doAction()
        {
            // Cell priority {up, right, down, left}
            //while (this.liveNode.Count != 0)
            while (this.curNode.TreasureFound < this.m.TreasureCount)
            {
                
                if (this.liveNode.Count != 0)
                {
                    Node tempNode = liveNode.Peek();
                    if (!BFS.isDiscovered(tempNode, this.discovered))
                    {
                        this.curNode = tempNode;
                        this.Discovered.Add(tempNode);
                        if (this.m.Content[curNode.I][curNode.J] == "T")
                        {
                            if (!curNode.hasInPath(curNode.I, curNode.J))
                            {
                                this.curNode.TreasureFound++;
                            }

                        }
                        if (this.curNode.TreasureFound == this.m.TreasureCount)
                        {
                            break;
                        }
                        Node upperNode = new Node(curNode.I - 1, curNode.J, curNode);
                        Node rightNode = new Node(curNode.I, curNode.J + 1, curNode);
                        Node bottomNode = new Node(curNode.I + 1, curNode.J, curNode);
                        Node leftNode = new Node(curNode.I, curNode.J - 1, curNode);
                        if (this.m.isIdxEff(curNode.I, curNode.J - 1) && this.m.Content[curNode.I][curNode.J - 1] != "X" && !curNode.hasInPath(curNode.I, curNode.J - 1) && !BFS.isDiscovered(leftNode, Discovered))
                        {
                            liveNode.Push(leftNode);
                        }
                        if (this.m.isIdxEff(curNode.I + 1, curNode.J) && this.m.Content[curNode.I + 1][curNode.J] != "X" && !curNode.hasInPath(curNode.I + 1, curNode.J) && !BFS.isDiscovered(bottomNode, Discovered))
                        {
                            liveNode.Push(bottomNode);
                        }
                        if (this.m.isIdxEff(curNode.I, curNode.J + 1) && this.m.Content[curNode.I][curNode.J + 1] != "X" && !curNode.hasInPath(curNode.I, curNode.J + 1) && !BFS.isDiscovered(rightNode, Discovered))
                        {
                            liveNode.Push(rightNode);
                        }
                        if (this.m.isIdxEff(curNode.I - 1, curNode.J) && this.m.Content[curNode.I - 1][curNode.J] != "X" && !curNode.hasInPath(curNode.I - 1, curNode.J) && !BFS.isDiscovered(upperNode, Discovered))
                        {
                            liveNode.Push(upperNode);
                        }
                    }
                    else
                    {
                        LiveNode.Pop();
                    }
                }
                else
                {
                    //CurNode = new Node(curNode.I, curNode.J, curNode);
                    Node tempCureNode = new Node(curNode.I, curNode.J);
                    discovered = new List<Node> { tempCureNode };
                    liveNode = new Stack<Node>();
                    if (this.m.isIdxEff(curNode.I - 1, curNode.J))
                    {
                        if (this.m.Content[curNode.I - 1][curNode.J] != "X")
                        {
                            Node upperNode = new Node(curNode.I - 1, curNode.J, curNode);
                            liveNode.Push(upperNode);
                        }
                    }
                    else if (this.m.isIdxEff(curNode.I, curNode.J + 1))
                    {
                        if (this.m.Content[curNode.I][curNode.J + 1] != "X")
                        {
                            Node upperNode = new Node(curNode.I, curNode.J + 1, curNode);
                            liveNode.Push(upperNode);
                        }
                    }
                    else if (this.m.isIdxEff(curNode.I + 1, curNode.J))
                    {
                        if (this.m.Content[curNode.I + 1][curNode.J] != "X")
                        {
                            Node upperNode = new Node(curNode.I + 1, curNode.J, curNode);
                            liveNode.Push(upperNode);
                        }
                    }
                    else if (this.m.isIdxEff(curNode.I, curNode.J - 1))
                    {
                        if (this.m.Content[curNode.I][curNode.J - 1] != "X")
                        {
                            Node upperNode = new Node(curNode.I, curNode.J - 1, curNode);
                            liveNode.Push(upperNode);
                        }
                    }
                }
            }
        }

    }
}
