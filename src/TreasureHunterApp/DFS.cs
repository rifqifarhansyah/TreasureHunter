using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using TreasureHunterApp;

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
        public DFS(Maze m, MainWindow mw)
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
            if (this.m.isIdxEff(curNode.I, curNode.J - 1) && this.m.Content[curNode.I][curNode.J - 1] != "X" && !curNode.isBackTrack(curNode.I, curNode.J - 1) && !BFS.IsDiscovered(leftNode, this.discovered))
            {
                liveNode.Push(leftNode);
                discover.Push((curNode.I, curNode.J - 1));
                cnt = 1;
                //addTotalPath(curNode.I, curNode.J-1);
            }
            if (this.m.isIdxEff(curNode.I + 1, curNode.J) && this.m.Content[curNode.I + 1][curNode.J] != "X" && !curNode.isBackTrack(curNode.I + 1, curNode.J) && !BFS.IsDiscovered(bottomNode, this.discovered))
            {
                liveNode.Push(bottomNode);
                discover.Push((curNode.I + 1, curNode.J));
                cnt = 1;
                //addTotalPath(curNode.I+1, curNode.J);
            }
            if (this.m.isIdxEff(curNode.I, curNode.J + 1) && this.m.Content[curNode.I][curNode.J + 1] != "X" && !curNode.isBackTrack(curNode.I, curNode.J + 1) && !BFS.IsDiscovered(rightNode, this.discovered))
            {
                liveNode.Push(rightNode);
                discover.Push((curNode.I, curNode.J + 1));
                cnt = 1;
                //addTotalPath(curNode.I, curNode.J+1);

            }
            if (this.m.isIdxEff(curNode.I - 1, curNode.J) && this.m.Content[curNode.I - 1][curNode.J] != "X" && !curNode.isBackTrack(curNode.I - 1, curNode.J) && !BFS.IsDiscovered(upperNode, this.discovered))
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
        public Node doAction(bool goBackHome, MainWindow mw, int delayDuration)
        {
            Task.Run(async () =>
            {
                int nodeCount = 0;
                Node resultNode = null;
                int mainProgramDelayCount = 0;
                int goBackHomeDelayCount = 0;
                Stopwatch mainStopwatch = Stopwatch.StartNew();
                int treasureFound = 0;
                resultNode = null;
                this.initializeStartingPoint(m.Start.i, m.Start.j);
                mw.Dispatcher.Invoke(() => {
                    ColorCurrentNode(mw);
                    ColorQueuedNode(mw); 
                });
                await Task.Delay(delayDuration);
                mainProgramDelayCount++;
                while (treasureFound != this.m.TreasureCount)
                {
                    while (true)
                    {
                        Node tempCurNode = liveNode.Pop();
                        if (!BFS.IsDiscovered(tempCurNode, discovered))
                        {
                            CurNode = tempCurNode;
                            nodeCount++;
                            this.discovered.Add(tempCurNode);
                            mw.Dispatcher.Invoke(() => { 
                                ColorCurrentNode(mw); 
                            });
                            await Task.Delay(delayDuration);
                            mainProgramDelayCount++;
                            if (this.m.Content[curNode.I][curNode.J] == "T" && !curNode.hasInPath(curNode.I, curNode.J))
                            {
                                treasureFound++;
                                this.m.Content[CurNode.I][CurNode.J] = "R";
                                resultNode = BFS.Append(resultNode, CurNode, m);
                                this.initializeStartingPoint(CurNode.I, CurNode.J);
                                while (Discovered.Count != 0)
                                {
                                    Discovered.RemoveAt(Discovered.Count - 1);
                                }
                                mw.Dispatcher.Invoke(() => {
                                    ClearNonPath(mw, resultNode);
                                    ColorQueuedNode(mw);
                                    mw.openChest(CurNode.I, CurNode.J);
                                });
                                await Task.Delay(delayDuration);
                                mainProgramDelayCount++;
                                break;
                            }
                            pushNode();
                            mw.Dispatcher.Invoke(() => { 
                                ColorQueuedNode(mw); 
                            });
                            await Task.Delay(delayDuration);
                            mainProgramDelayCount++;
                        }

                    }
                }
                mainStopwatch.Stop();
                TimeSpan elapsedTime = mainStopwatch.Elapsed - TimeSpan.FromMilliseconds(mainProgramDelayCount * delayDuration);
                if (goBackHome) {
                    Stopwatch goBackHomeStopwatch = Stopwatch.StartNew();
                    this.initializeStartingPoint(resultNode.I, resultNode.J);
                    mw.Dispatcher.Invoke(() => {
                        ColorCurrentNode(mw);
                        ColorQueuedNode(mw); 
                    });
                    await Task.Delay(delayDuration);
                    goBackHomeDelayCount++;
                    while (this.liveNode.Count != 0)
                    {
                        Node tempNode = liveNode.Pop();

                        if (this.m.Content[tempNode.I][tempNode.J] == "K")
                        {
                            this.curNode = tempNode;
                            nodeCount++;
                            this.discovered.Add(tempNode);
                            break;
                        }
                        if (!BFS.IsDiscovered(tempNode, this.discovered) && !curNode.hasInPath(curNode.I, curNode.J))
                        {
                            mw.Dispatcher.Invoke(() => { 
                                ColorCurrentNode(mw); 
                            });
                            await Task.Delay(delayDuration);
                            goBackHomeDelayCount++;
                            this.curNode = tempNode;
                            nodeCount++;
                            this.discovered.Add(tempNode);
                            if (this.m.Content[curNode.I][curNode.J] == "K")
                            {
                                break;
                            }
                            pushNode();
                            mw.Dispatcher.Invoke(() => {
                                ColorQueuedNode(mw);
                            });
                            await Task.Delay(delayDuration);
                            goBackHomeDelayCount++;
                        }
                    }
                    resultNode = BFS.Append(resultNode, curNode, this.m);
                    goBackHomeStopwatch.Stop();
                    TimeSpan elapsedTSP = goBackHomeStopwatch.Elapsed - TimeSpan.FromMilliseconds(goBackHomeDelayCount * delayDuration);
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
