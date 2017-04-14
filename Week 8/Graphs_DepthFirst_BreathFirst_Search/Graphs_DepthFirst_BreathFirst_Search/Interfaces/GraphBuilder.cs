using System;

namespace Graphs_DepthFirst_BreathFirst_Search.Interfaces
{
    public interface GraphBuilder
    {
        Node createNode(string name);
        void createEdge(Node begin, Node end);
        Graph build();
    }
}
