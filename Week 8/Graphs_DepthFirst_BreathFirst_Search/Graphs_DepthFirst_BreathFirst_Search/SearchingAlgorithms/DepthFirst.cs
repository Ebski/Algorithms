using System.Collections.Generic;
using System.Threading;
using Graphs_DepthFirst_BreathFirst_Search.Interfaces;

namespace Graphs_DepthFirst_BreathFirst_Search.SearchingAlgorithms
{
    public class DepthFirst
    {
        public static List<Node> runDepthFirst(Node start)
        {
            Queue<Node> queue = new Queue<Node>();
            HashSet<Node> visited = new HashSet<Node>();
            List<Node> res = new List<Node>();
            queue.Enqueue(start);
            visited.Add(start);
            recurse(queue, visited, res);
            return res;
        }

        private static void recurse(Queue<Node> queue, HashSet<Node> visited, List<Node> res)
        {
            if (queue.Count == 0) return;
            Node next = queue.Dequeue();
            res.Add(next);
            foreach (Edge e in next.getFromEdges())
            {
                Node end = e.getEnd();
                if (visited.Contains(end)) continue;
                visited.Add(end);
                queue.Enqueue(end);
                recurse(queue, visited, res);
            }
        }
    }
}
