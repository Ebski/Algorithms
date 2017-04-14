using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Graphs_DepthFirst_BreathFirst_Search.Interfaces
{
    public interface Graph
    {
        IEnumerable<Node> getNodes();
        Node findNode(string name);
    }
}
