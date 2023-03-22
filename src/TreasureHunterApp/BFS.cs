using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using TreasureHunterApp;

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
            discovered = new List<Node>();
            liveNode = new Queue<Node>();
        }
        public BFS(Maze m, MainWindow mw)
        {
            this.m = m;
            this.initializeStartingPoint(this.m.Start.i, this.m.Start.j);
            colorQueuedNode(mw);
            colorCurrentNode(mw);
        }
        public Node CurNode
        {
            get { return this.curNode; }
            set { this.curNode = value; }
        }
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
        public Node doAction(bool goBackHome, MainWindow mw)
        {
            Task.Run(async () =>
            {
                Node resultNode = null;
                if (curNode != null)
                {
                    resultNode = append(resultNode, curNode, this.m);
                    initializeStartingPoint(m.Start.i, m.Start.j);
                    mw.Dispatcher.Invoke(() => {
                        colorCurrentNode(mw);
                        colorQueuedNode(mw);
                    });
                    while (this.liveNode.Count != 0)
                    {
                        Node tempNode = liveNode.Dequeue();
                        if (!isDiscovered(tempNode, this.discovered))
                        {
                            this.curNode = tempNode;
                            this.discovered.Add(tempNode);
                            mw.Dispatcher.Invoke(() => {
                                colorCurrentNode(mw);
                            });
                            await Task.Delay(100);
                            if (this.m.Content[curNode.I][curNode.J] == "T" && !curNode.hasInPath(curNode.I, curNode.J))
                            {
                                mw.Dispatcher.Invoke(() => { clearNonPath(mw, resultNode); });
                                await Task.Delay(100);
                                this.curNode.TreasureFound++;
                            }
                            if (CurNode.TreasureFound == this.m.TreasureCount)
                            {
                                break;
                            }
                            enqueueValidNode();
                            mw.Dispatcher.Invoke(() => {
                                colorQueuedNode(mw);
                            });
                            await Task.Delay(100);
                    
                        }
                    }
                    
                }
                else
                {
                    int treasureFound = 0;
                    resultNode = null;
                    this.initializeStartingPoint(m.Start.i, m.Start.j);
                    mw.Dispatcher.Invoke(() => { colorCurrentNode(mw); colorQueuedNode(mw); });
                    await Task.Delay(100);
                    while (treasureFound != this.m.TreasureCount)
                    {
                        while (true)
                        {
                            Node tempCurNode = liveNode.Dequeue();
                            if (!isDiscovered(tempCurNode, discovered))
                            {
                                CurNode = tempCurNode;
                                this.discovered.Add(tempCurNode);
                                mw.Dispatcher.Invoke(() => { colorCurrentNode(mw); });
                                await Task.Delay(100);
                                if (this.m.Content[CurNode.I][CurNode.J] == "T")
                                {
                                    treasureFound++;
                                    this.m.Content[CurNode.I][CurNode.J] = "R";
                                    resultNode = append(resultNode, CurNode, m);
                                    mw.Dispatcher.Invoke(() => { colorCurrentNode(mw); clearNonPath(mw, resultNode); });
                                    await Task.Delay(100);
                                    this.initializeStartingPoint(CurNode.I, CurNode.J);
                                    break;
                                }
                                enqueueValidNode();
                                mw.Dispatcher.Invoke(() => { colorQueuedNode(mw); });
                                await Task.Delay(100);
                            }
                        }
                    }
                    mw.Dispatcher.Invoke(() => { clearNonPath(mw, resultNode); });
                    await Task.Delay(100);
                }
                // if (CurNode.TreasureFound != this.m.TreasureCount)
                // {
                // }
                // else
                // {
                //     resultNode = new Node(curNode.I, curNode.J, curNode.Path, curNode.Route, curNode.TreasureFound);
                // }
                if (goBackHome)
                {
                    this.initializeStartingPoint(resultNode.I, resultNode.J);
                    mw.Dispatcher.Invoke(() => { colorCurrentNode(mw); colorQueuedNode(mw); });
                    await Task.Delay(100);
                    while (this.liveNode.Count != 0)
                    {
                        Node tempNode = liveNode.Dequeue();
                        if (!isDiscovered(tempNode, this.discovered))
                        {
                            this.curNode = tempNode;
                            mw.Dispatcher.Invoke(() => { colorCurrentNode(mw); });
                            await Task.Delay(100);
                            this.discovered.Add(tempNode);
                            if (this.m.Content[curNode.I][curNode.J] == "K")
                            {
                                mw.Dispatcher.Invoke(() => { clearNonPath(mw, resultNode); });
                                await Task.Delay(100);
                                break;
                            }
                            enqueueValidNode();
                            mw.Dispatcher.Invoke(() => { colorQueuedNode(mw); });
                            await Task.Delay(100);
                        }
                    }
                    resultNode = append(resultNode, curNode, this.m);
                }
                return resultNode;
            });
            return null;

        }
        public void getOneWay()
        {
            while (this.liveNode.Count != 0)
            {
                Node tempNode = liveNode.Dequeue();
                if (!isDiscovered(tempNode, this.discovered))
                {
                    curNode = tempNode;
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
            if (curNode.TreasureFound != this.m.TreasureCount)
            {
                curNode = null;
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
        public void colorQueuedNode(MainWindow mw)
        {
            foreach (var tile in liveNode)
            {
                mw.changeLightGray(tile.I, tile.J);
            }
        }
        public void colorCurrentNode(MainWindow mw)
        {
            mw.changeGreen(CurNode.I, CurNode.J);
        }
        public void clearNonPath(MainWindow mw, Node nodePaths)
        {
            if (nodePaths != null)
            {
                for (int i = 0; i < this.m.Width; i++)
                {
                    for (int j = 0; j < this.m.Length; j++)
                    {
                        if (!nodePaths.hasInPath(i, j) && i != nodePaths.I && j != nodePaths.J && this.m.Content[i][j] != "X")
                        {
                            mw.changeWhite(i, j);
                        }
                    }
                }
            }
        }
    }
}
