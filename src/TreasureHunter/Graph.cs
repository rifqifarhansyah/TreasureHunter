using System.Collections.Generic;

namespace Graph
{
    public class Graph
    {
        Dictionary<(int i, int j), bool> adjacencyMatrix;
        List<(int i, int j)> treasureCoordinates;
        (int i, int j) startCoordinate;

        public Graph()
        {
            adjacencyMatrix = new Dictionary<(int i, int j), bool>();
            treasureCoordinates = new List<(int i, int j)>();
            startCoordinate = (0, 0);
        }

        public Graph(Dictionary<(int i, int j), bool> am, List<(int i, int j)> tc, (int i, int j) sc)
        {
            adjacencyMatrix = am;
            treasureCoordinates = tc;
            startCoordinate = sc;
        }

        public Dictionary<(int i, int j), bool> AdjacencyMatrix { get { return adjacencyMatrix; } set { adjacencyMatrix = value; } }
        public List<(int i, int j)> TreasureCoordinates { get { return treasureCoordinates; } set { treasureCoordinates = value; } }
        public (int i, int j) StartCoordinate { get { return startCoordinate; } set { startCoordinate = value; } }
    }
}
