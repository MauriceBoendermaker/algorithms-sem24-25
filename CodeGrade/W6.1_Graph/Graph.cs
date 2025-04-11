namespace Solution;

public class Graph
{
    public double[,] AdjacencyMatrix { get; set; }
    public int Count { get { return AdjacencyMatrix.GetLength(0); } }  //Number of nodes in the graph

    public Graph(double[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
            throw new System.ArgumentException("The adjacency matrix must be a square matrix");
        AdjacencyMatrix = matrix;
    }

    //Breadth First Traversal
    public string BFT(int root)
    {
        // create empty queue and enqueue the root
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(root);

        // create array of booleans to keep track of visited nodes and set the root flag to true
        bool[] visited = new bool[Count];
        visited[root] = true;

        // Loop until queue is empty
        string result = "";
        while (queue.Count > 0)
        {
            // dequeue a node
            int current = queue.Dequeue();

            // add the current node (followed by a space) to the string
            result += current + " ";

            // find neighbors of current
            foreach (int neighbor in Neighbors(current))
            {
                // enqueue all neighbors which are not visited yet and set them to visited
                if (!visited[neighbor])
                {
                    queue.Enqueue(neighbor);
                    visited[neighbor] = true;
                }
            }
        }

        return result.Trim();
    }

    //Nodes adjacent to a given node
    public List<int> Neighbors(int node)
    {
        List<int> neighbors = new List<int>();

        for (int i = 0; i < AdjacencyMatrix.GetLength(0); i++)
        {
            if (AdjacencyMatrix[node, i] < Double.PositiveInfinity)
            {
                neighbors.Add(i);
            }
        }

        return neighbors;
    }

    //Nodes (adjacent to a given node) to be visited in reversed order
    public List<int> NeighborsReversed(int node)
    {
        List<int> neighbors = new List<int>();

        for (int i = 0; i < AdjacencyMatrix.GetLength(0); i++)
        {
            if (AdjacencyMatrix[node, i] < Double.PositiveInfinity)
            {
                neighbors.Add(i);
            }
        }
        neighbors.Reverse();

        return neighbors;
    }

    //Depth First Traveral
    public string DFT(int root)
    {
        // create empty stack and push the root into it
        Stack<int> stack = new Stack<int>();
        stack.Push(root);

        // create array of booleans to keep track of visited nodes
        bool[] visited = new bool[Count];

        // Loop until stack is empty
        string result = "";

        while (stack.Count > 0)
        {
            // pop a node from the stack 
            int current = stack.Pop();

            // check if current node is not visited yet
            // add current node to the string (followed by a space) and set it to visited
            if (!visited[current])
            {
                result += current + " ";
                visited[current] = true;

                // find neighbors (in reversed order) of current  
                // push all neighbors 
                foreach (int neighbor in NeighborsReversed(current))
                {
                    stack.Push(neighbor);
                }
            }
        }

        return result.Trim();
    }

    //Dijkstra's algorithm SingleSourceShortestPath 
    public Tuple<double[], int[]> SingleSourceShortestPath(int source) //distance and prev arrays
    {
        // initialization of distance, prev and unvisitedNodes
        // default distance: double.PositiveInfinity
        // default previous node: -1
        double[] dist = new double[Count];
        int[] prev = new int[Count];
        HashSet<int> unvisited = new HashSet<int>();

        for (int i = 0; i < Count; i++)
        {
            dist[i] = double.PositiveInfinity;
            prev[i] = -1;
            unvisited.Add(i);
        }

        // set distance of source
        dist[source] = 0;

        // Loop until unvisitedNodes is empty
        while (unvisited.Count > 0)
        {
            // find closest node in unvisitedNodes
            int u = unvisited.OrderBy(x => dist[x]).First();

            // remove the closest node from unvisitedNodes
            unvisited.Remove(u);

            //considering all neighbors of the closest node
            foreach (int neighbor in Neighbors(u))
            {
                // calculate distance and update distance (and previous node) if smaller
                double alt = dist[u] + AdjacencyMatrix[u, neighbor];
                
                if (alt < dist[neighbor])
                {
                    dist[neighbor] = alt;
                    prev[neighbor] = u;
                }
            }
        }

        return new Tuple<double[], int[]>(dist, prev);
    }
}


