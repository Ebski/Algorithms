using System.Collections.Generic;
using Graphs_DepthFirst_BreathFirst_Search.Interfaces;

namespace Graphs_DepthFirst_BreathFirst_Search.MySimpleGraph
{
    public class MyNode : Node
    {
        private string name;
        public List<Edge> edges { get; set; }
        public MyNode(string name)
        {
            this.name = name;
            edges = new List<Edge>();
        }

        public string getName()
        {
            return name;
        }

        public IEnumerable<Edge> getFromEdges()
        {
            return edges;
        }

        public void addEdge(Node end)
        {
            edges.Add(new MyEdge(this, end));
        }
    }
}
