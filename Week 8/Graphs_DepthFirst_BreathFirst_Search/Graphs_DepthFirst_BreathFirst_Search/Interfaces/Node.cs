using System.Collections.Generic;

namespace Graphs_DepthFirst_BreathFirst_Search.Interfaces
{
    public interface Node
    {
        string getName();
        IEnumerable<Edge> getFromEdges();
    }
}
