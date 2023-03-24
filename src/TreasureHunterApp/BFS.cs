using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Diagnostics;
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
            this.InitializeStartingPoint(this.m.Start.i, this.m.Start.j);
        }
        public Node CurNode
        {
            get { return this.curNode; }
            set { this.curNode = value; }
        }
        public void InitializeStartingPoint(int startI, int startJ)
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
        public void EnqueueValidNode()
        {
            Node upperNode = new Node(curNode.I - 1, curNode.J, curNode);
            Node rightNode = new Node(curNode.I, curNode.J + 1, curNode);
            Node bottomNode = new Node(curNode.I + 1, curNode.J, curNode);
            Node leftNode = new Node(curNode.I, curNode.J - 1, curNode);
            if (this.m.isIdxEff(curNode.I - 1, curNode.J) && this.m.Content[curNode.I - 1][curNode.J] != "X" && !curNode.hasInPath(curNode.I - 1, curNode.J) && !IsDiscovered(upperNode, this.discovered))
            {
                liveNode.Enqueue(upperNode);
            }
            if (this.m.isIdxEff(curNode.I, curNode.J + 1) && this.m.Content[curNode.I][curNode.J + 1] != "X" && !curNode.hasInPath(curNode.I, curNode.J + 1) && !IsDiscovered(rightNode, this.discovered))
            {
                liveNode.Enqueue(rightNode);

            }
            if (this.m.isIdxEff(curNode.I + 1, curNode.J) && this.m.Content[curNode.I + 1][curNode.J] != "X" && !curNode.hasInPath(curNode.I + 1, curNode.J) && !IsDiscovered(bottomNode, this.discovered))
            {
                liveNode.Enqueue(bottomNode);
            }
            if (this.m.isIdxEff(curNode.I, curNode.J - 1) && this.m.Content[curNode.I][curNode.J - 1] != "X" && !curNode.hasInPath(curNode.I, curNode.J - 1) && !IsDiscovered(leftNode, this.discovered))
            {
                liveNode.Enqueue(leftNode);
            }
        }
        public Node DoAction(bool goBackHome, MainWindow mw, int delayDuration)
        {
            Task.Run(async () =>
            {
                Node resultNode = null;
                int nodeCount = 0;
                int mainProgram = 0;
                int tSP = 0;
                Stopwatch mainStopwatch = Stopwatch.StartNew();
                int treasureFound = 0;
                this.InitializeStartingPoint(m.Start.i, m.Start.j);
                mw.Dispatcher.Invoke(() => {
                    ColorCurrentNode(mw);
                    ColorQueuedNode(mw); 
                });
                await Task.Delay(delayDuration);
                mainProgram++;
                while (treasureFound != this.m.TreasureCount)
                {
                    while (true)
                    {
                        Node tempCurNode = liveNode.Dequeue();
                        if (!IsDiscovered(tempCurNode, discovered))
                        {
                            CurNode = tempCurNode;
                            nodeCount++;
                            this.discovered.Add(tempCurNode);
                            mw.Dispatcher.Invoke(() => { 
                                ColorCurrentNode(mw); 
                            });
                            await Task.Delay(delayDuration);
                            mainProgram++;
                            if (this.m.Content[CurNode.I][CurNode.J] == "T")
                            {
                                treasureFound++;
                                this.m.Content[CurNode.I][CurNode.J] = "R";
                                resultNode = Append(resultNode, CurNode, m);
                                this.InitializeStartingPoint(CurNode.I, CurNode.J);
                                mw.Dispatcher.Invoke(() => {
                                    ClearNonPath(mw, resultNode);
                                    ColorQueuedNode(mw);
                                    mw.openChest(CurNode.I, CurNode.J);
                                });
                                await Task.Delay(delayDuration);
                                mainProgram++;
                                break;
                            }
                            EnqueueValidNode();
                            mw.Dispatcher.Invoke(() => { 
                                ColorQueuedNode(mw); 
                            });
                            await Task.Delay(delayDuration);
                            mainProgram++;
                        }
                    }
                }
                mainStopwatch.Stop();
                TimeSpan elapsedTime = mainStopwatch.Elapsed - TimeSpan.FromMilliseconds(mainProgram * delayDuration);
                if (goBackHome)
                {
                    Stopwatch tspStopwatch = Stopwatch.StartNew();
                    this.InitializeStartingPoint(resultNode.I, resultNode.J);
                    mw.Dispatcher.Invoke(() => {
                        ColorCurrentNode(mw);
                        ColorQueuedNode(mw); 
                    });
                    await Task.Delay(delayDuration);
                    tSP++;
                    while (this.liveNode.Count != 0)
                    {
                        Node tempNode = liveNode.Dequeue();
                        if (!IsDiscovered(tempNode, this.discovered))
                        {
                            this.curNode = tempNode;
                            nodeCount++;
                            mw.Dispatcher.Invoke(() => { 
                                ColorCurrentNode(mw); 
                            });
                            await Task.Delay(delayDuration);
                            tSP++;
                            this.discovered.Add(tempNode);
                            if (this.m.Content[curNode.I][curNode.J] == "K")
                            {
                                break;
                            }
                            EnqueueValidNode();
                            mw.Dispatcher.Invoke(() => { 
                                ColorQueuedNode(mw); 
                            });
                            await Task.Delay(delayDuration);
                            tSP++;
                        }
                    }
                    resultNode = Append(resultNode, curNode, this.m);
                    tspStopwatch.Stop();
                    TimeSpan elapsedTSP = tspStopwatch.Elapsed - TimeSpan.FromMilliseconds(delayDuration * tSP);
                    elapsedTime += elapsedTSP;
                }
                mw.Dispatcher.Invoke(() => {
                    ClearNonPath(mw, resultNode);
                    string v = string.Join(" - ", resultNode.Route);
                    mw.directions.Text = v;
                    mw.nodeCount.Text = "Nodes: " + nodeCount.ToString();
                    mw.stepCount.Text = "Steps: " + (resultNode.Route.Count()).ToString();
                    mw.elapsedTime.Text = "Elapsed Time: " + ((int)elapsedTime.TotalMilliseconds).ToString() + " ms";
                });
                await Task.Delay(delayDuration);
                return resultNode;
            });
            return null;

        }

        public static bool IsDiscovered(Node n, List<Node> discoveredNodes)
        {
            foreach (var node in discoveredNodes)
            {
                if (node.I == n.I && node.J == n.J) return true;
            }
            return false;
        }

        public static Node Append(Node a, Node b, Maze m)
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
        public void ColorQueuedNode(MainWindow mw)
        {
            foreach (var tile in liveNode)
            {
                mw.changeLightGray(tile.I, tile.J);
            }
        }
        public void ColorCurrentNode(MainWindow mw)
        {
            mw.changeGreen(CurNode.I, CurNode.J);
        }
        public void ClearNonPath(MainWindow mw, Node nodePaths)
        {
            if (nodePaths != null)
            {
                for (int i = 0; i < this.m.Width; i++)
                {
                    for (int j = 0; j < this.m.Length; j++)
                    {
                        if (this.m.Content[i][j] != "X")
                        {
                            int tileOccurences = nodePaths.countTileOccurence(i, j);
                            if (tileOccurences == 0)
                            {
                                mw.changeWhite(i, j);
                            }
                            else if (tileOccurences <= 7)
                            {
                                mw.turnGreenShade(i, j, tileOccurences);
                            }
                            else
                            {
                                mw.turnPurple(i, j);
                            }
                        }
                    }
                }
            }
        }
    }
}
