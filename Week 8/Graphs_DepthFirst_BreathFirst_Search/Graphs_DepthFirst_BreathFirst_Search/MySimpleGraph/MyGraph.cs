using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graphs_DepthFirst_BreathFirst_Search.Interfaces;

namespace Graphs_DepthFirst_BreathFirst_Search.MySimpleGraph
{
    public class MyGraph : Graph
    {
        private IEnumerable<Node> nodes;

        public MyGraph(IEnumerable<Node> nodes)
        {
            this.nodes = nodes;
        }

        public IEnumerable<Node> getNodes()
        {
            return nodes;
        }

        public Node findNode(string name)
        {
            return nodes.FirstOrDefault(node => node.getName().Equals(name));
        }
    }
}
