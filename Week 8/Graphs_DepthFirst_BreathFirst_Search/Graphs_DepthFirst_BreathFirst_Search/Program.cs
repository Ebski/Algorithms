using System;
using System.Collections.Generic;
using Graphs_DepthFirst_BreathFirst_Search.Interfaces;
using Graphs_DepthFirst_BreathFirst_Search.MySimpleGraph;
using Graphs_DepthFirst_BreathFirst_Search.SearchingAlgorithms;

namespace Graphs_DepthFirst_BreathFirst_Search
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GraphBuilder gb = new MyGraphBuilder();

            Node a = gb.createNode("A");
            Node b = gb.createNode("B");
            Node c = gb.createNode("C");
            Node d = gb.createNode("D");
            Node e = gb.createNode("E");

            gb.createEdge(a, b);
            gb.createEdge(b, a);
            gb.createEdge(b, c);
            gb.createEdge(c, d);
            gb.createEdge(a, d);
            gb.createEdge(d, a);
            gb.createEdge(c, e);
            gb.createEdge(e, d);
            gb.createEdge(c, c);

            Graph g = gb.build();
            IEnumerable<Node> resBreathFirst = BreathFirst.runBreathFirst(a);
            IEnumerable<Node> resDepthFirst = DepthFirst.runDepthFirst(a);

            foreach (Node node in resBreathFirst)
            {
                Console.WriteLine(node.getName());
            }

            Console.WriteLine("\n------------------------------------\n");

            foreach (Node node in resDepthFirst)
            {
                Console.WriteLine(node.getName());
            }

            while (true)
            {
                
            }
        }
    }
}
