using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using Graphs_DepthFirst_BreathFirst_Search.Interfaces;

namespace Graphs_DepthFirst_BreathFirst_Search.MySimpleGraph
{
    public class MyGraphBuilder : GraphBuilder
    {
        private List<Node> nodes;

        public MyGraphBuilder()
        {
            nodes = new List<Node>();
        }

        public Node createNode(string name)
        {
            Node node = new MyNode(name);
            nodes.Add(node);
            return node;
        }
        
        public void createEdge(Node begin, Node end)
        {
            if (begin.GetType() == typeof(MyNode) && end.GetType() == typeof(MyNode))
            {
                MyNode beginImplementation = (MyNode)begin;
                beginImplementation.addEdge(end);
            }
            else
            {
                throw new InstanceNotFoundException("The nodes must be created with the same GraphBuilders!");
            }
        }

        public Graph build()
        {
            return new MyGraph(nodes);
        }
    }
}
