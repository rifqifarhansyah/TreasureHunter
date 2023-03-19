﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureHunterAlgo;

namespace BackendDebugger { 
    class BackendDebugger
    {
        public static void Main(string[] args)
        {
            Maze m = new Maze("D:\\ITB\\Semester 4\\Strategi Algoritma\\Tubes2_13521099\\test\\test4.txt");
            BFS bFS = new BFS(m);
            bFS.doAction();
            Node solutionNode = bFS.CurNode;
            // DFS dFS = new DFS(m);
            // dFS.doAction();
            // Node dFSSolution = dFS.CurNode;
        }
    }
}