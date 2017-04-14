using Graphs_DepthFirst_BreathFirst_Search.Interfaces;

namespace Graphs_DepthFirst_BreathFirst_Search.MySimpleGraph
{
    public class MyEdge : Edge
    {
        private MyNode begin;
        private Node end;
        public MyEdge(MyNode begin, Node end)
        {
            this.begin = begin;
            this.end = end;
        }

        public Node getBegin()
        {
            return begin;
        }

        public Node getEnd()
        {
            return end;
        }
    }
}
