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
        private Stack<(int ix, int jx)> discover = new Stack<(int, int)>();

        public Maze M { get => m; set => m = value; }
        public Node CurNode { get => curNode; set => curNode = value; }
        public List<Node> Discovered { get => discovered; set => discovered = value; }
        public Stack<Node> LiveNode { get => liveNode; set => liveNode = value; }



        public DFS()
        {
            M = new Maze();
            CurNode = new Node();
            discovered = new List<Node>();
            liveNode = new Stack<Node>();
            //discover = new Stack<(int ix, int jx)>();
        }
        public DFS(Maze m)
        {
            M = m;
            CurNode = new Node(m.Start.i, m.Start.j);
            discovered = new List<Node> { curNode };
            liveNode = new Stack<Node>();
            //discover = new Stack<(int ix, int jx)>();
            if (this.m.isIdxEff(curNode.I, curNode.J - 1))
            {
                if (this.m.Content[curNode.I][curNode.J - 1] != "X")
                {
                    Node upperNode = new Node(curNode.I, curNode.J - 1, curNode);
                    liveNode.Push(upperNode);
                    discover.Push((curNode.I, curNode.J - 1));
                    //addTotalPath(curNode.I, curNode.J-1);
                }
            }
            if (this.m.isIdxEff(curNode.I + 1, curNode.J))
            {
                if (this.m.Content[curNode.I + 1][curNode.J] != "X")
                {
                    Node upperNode = new Node(curNode.I + 1, curNode.J, curNode);
                    liveNode.Push(upperNode);
                    discover.Push((curNode.I + 1, curNode.J));
                    //addTotalPath(curNode.I+1, curNode.J);
                }
            }
            if (this.m.isIdxEff(curNode.I, curNode.J + 1))
            {
                if (this.m.Content[curNode.I][curNode.J + 1] != "X")
                {
                    Node upperNode = new Node(curNode.I, curNode.J + 1, curNode);
                    liveNode.Push(upperNode);
                    discover.Push((curNode.I, curNode.J + 1));
                    //addTotalPath(curNode.I, curNode.J+1);
                }
            }
            if (this.m.isIdxEff(curNode.I - 1, curNode.J))
            {
                if (this.m.Content[curNode.I - 1][curNode.J] != "X")
                {
                    Node upperNode = new Node(curNode.I - 1, curNode.J, curNode);
                    liveNode.Push(upperNode);
                    discover.Push((curNode.I - 1, curNode.J));
                    //addTotalPath(curNode.I-1, curNode.J);
                }
            }
        }

        public void pushNode()
        {
            Node upperNode = new Node(curNode.I - 1, curNode.J, curNode);
            Node rightNode = new Node(curNode.I, curNode.J + 1, curNode);
            Node bottomNode = new Node(curNode.I + 1, curNode.J, curNode);
            Node leftNode = new Node(curNode.I, curNode.J - 1, curNode);
            int cnt = 0;
            if (this.m.isIdxEff(curNode.I, curNode.J - 1) && this.m.Content[curNode.I][curNode.J - 1] != "X" && !curNode.isBackTrack(curNode.I, curNode.J - 1) && !BFS.isDiscovered(leftNode, this.discovered))
            {
                liveNode.Push(leftNode);
                discover.Push((curNode.I, curNode.J - 1));
                cnt = 1;
                //addTotalPath(curNode.I, curNode.J-1);
            }
            if (this.m.isIdxEff(curNode.I + 1, curNode.J) && this.m.Content[curNode.I + 1][curNode.J] != "X" && !curNode.isBackTrack(curNode.I + 1, curNode.J) && !BFS.isDiscovered(bottomNode, this.discovered))
            {
                liveNode.Push(bottomNode);
                discover.Push((curNode.I + 1, curNode.J));
                cnt = 1;
                //addTotalPath(curNode.I+1, curNode.J);
            }
            if (this.m.isIdxEff(curNode.I, curNode.J + 1) && this.m.Content[curNode.I][curNode.J + 1] != "X" && !curNode.isBackTrack(curNode.I, curNode.J + 1) && !BFS.isDiscovered(rightNode, this.discovered))
            {
                liveNode.Push(rightNode);
                discover.Push((curNode.I, curNode.J + 1));
                cnt = 1;
                //addTotalPath(curNode.I, curNode.J+1);

            }
            if (this.m.isIdxEff(curNode.I - 1, curNode.J) && this.m.Content[curNode.I - 1][curNode.J] != "X" && !curNode.isBackTrack(curNode.I - 1, curNode.J) && !BFS.isDiscovered(upperNode, this.discovered))
            {
                liveNode.Push(upperNode);
                discover.Push((curNode.I - 1, curNode.J));
                cnt = 1;
                //addTotalPath(curNode.I-1, curNode.J);
            }
            if (cnt == 0)
            {
                discover.Pop();
            }
        }
        public void initializeStartingPoint(int startI, int startJ)
        {
            curNode = new Node(startI, startJ);
            discovered = new List<Node> { curNode };
            liveNode = new Stack<Node>();
            Node upperNode = new Node(curNode.I - 1, curNode.J, curNode);
            Node rightNode = new Node(curNode.I, curNode.J + 1, curNode);
            Node bottomNode = new Node(curNode.I + 1, curNode.J, curNode);
            Node leftNode = new Node(curNode.I, curNode.J - 1, curNode);
            if (this.m.isIdxEff(curNode.I, curNode.J - 1) && this.m.Content[curNode.I][curNode.J - 1] != "X")
            {
                liveNode.Push(leftNode);
                discover.Push((curNode.I, curNode.J - 1));
                //addTotalPath(curNode.I, curNode.J-1);
            }
            if (this.m.isIdxEff(curNode.I + 1, curNode.J) && this.m.Content[curNode.I + 1][curNode.J] != "X")
            {
                liveNode.Push(bottomNode);
                discover.Push((curNode.I + 1, curNode.J));
                //addTotalPath(curNode.I+1, curNode.J);
            }
            if (this.m.isIdxEff(curNode.I, curNode.J + 1) && this.m.Content[curNode.I][curNode.J + 1] != "X")
            {
                liveNode.Push(rightNode);
                discover.Push((curNode.I, curNode.J + 1));
                //addTotalPath(curNode.I, curNode.J+1);
            }
            if (this.m.isIdxEff(curNode.I - 1, curNode.J) && this.m.Content[curNode.I - 1][curNode.J] != "X")
            {
                liveNode.Push(upperNode);
                discover.Push((curNode.I - 1, curNode.J));
                //addTotalPath(curNode.I-1, curNode.J);
            }
        }

        public bool discoverPoint(int i, int j)
        {
            foreach (var item in discover)
            {
                if (i == item.ix && j == item.jx) return true;
            }
            return false;
        }

        public static bool isDiscoveredFirst(Node n, List<Node> discoveredNodes)
        {
            foreach (var node in discoveredNodes)
            {
                if (node.I == n.I && node.J == n.J) return true;
            }
            return false;
        }

        public Node doAction()
        {
            //kalau ada satu treasure yang ditemukan, maka langsung keluar dari loop
            while (this.liveNode.Count != 0)
            {
                Node tempNode = liveNode.Pop();
                if (!BFS.isDiscovered(tempNode, this.discovered) && !isDiscoveredFirst(tempNode, this.discovered))
                {
                    this.curNode = tempNode;
                    this.discovered.Add(tempNode);
                    if (this.m.Content[curNode.I][curNode.J] == "T" && !curNode.hasInPath(curNode.I, curNode.J))
                    {
                        while (Discovered.Count != 0)
                        {
                            Discovered.RemoveAt(Discovered.Count - 1);
                        }
                        this.curNode.TreasureFound++;
                    }
                    if (CurNode.TreasureFound == this.m.TreasureCount)
                    {
                        break;
                    }
                    pushNode();
                }
                //discover.Pop();
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
                        Node tempCurNode = liveNode.Pop();
                        if (!BFS.isDiscovered(tempCurNode, discovered))
                        {
                            CurNode = tempCurNode;
                            this.discovered.Add(tempCurNode);
                            if (this.m.Content[curNode.I][curNode.J] == "T" && !curNode.hasInPath(curNode.I, curNode.J))
                            {
                                treasureFound++;
                                this.m.Content[CurNode.I][CurNode.J] = "R";
                                resultNode = BFS.append(resultNode, CurNode, m);
                                this.initializeStartingPoint(CurNode.I, CurNode.J);
                                while (Discovered.Count != 0)
                                {
                                    Discovered.RemoveAt(Discovered.Count - 1);
                                }
                                break;
                            }
                            pushNode();
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
                Node tempNode = liveNode.Pop();

                if (this.m.Content[tempNode.I][tempNode.J] == "K")
                {
                    this.curNode = tempNode;
                    this.discovered.Add(tempNode);
                    break;
                }
                if (!BFS.isDiscovered(tempNode, this.discovered) && !curNode.hasInPath(curNode.I, curNode.J))
                {
                    this.curNode = tempNode;
                    this.discovered.Add(tempNode);
                    if (this.m.Content[curNode.I][curNode.J] == "K")
                    {
                        break;
                    }
                    pushNode();
                }
            }
            resultNode = BFS.append(resultNode, curNode, this.m);
            return resultNode;
        }

    }
}
