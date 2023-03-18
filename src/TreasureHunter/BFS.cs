using System.Collections.Generic;
using System.Text;

namespace TreasureHunterAlgo
{
    public class BFS
    {
        private Maze m;
        private Node curNode;
        private List<Node> discovered;
        private Queue<Node> liveNode;
        private int treasureFound;
        public BFS()
        {
            m = new Maze();
            curNode = new Node();
            discovered = new List<Node> ();
            liveNode =  new Queue<Node> ();
            treasureFound = 0;
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
            this.treasureFound = 0;
        }
        public void doAction()
        {
            // Cell priority {up, right, down, left}
            while (treasureFound != this.m.TreasureCount && this.liveNode.Count != 0)
            {
                Node tempNode = liveNode.Dequeue();
            }
        }
        
    }
}
