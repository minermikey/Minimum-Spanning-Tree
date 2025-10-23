// THis edge class is used for connecting 2 nodes together 
namespace MinimumSpanningTree {

    public class Graph{

        public int VerticesCount;
        public List<Edge> Edges;

        public Graph(int vertices) {
            VerticesCount = vertices;
            
            Edges = new List<Edge>();
        }
            
        // Adds a mew connectin between two verticies with a given weight 
        public void AddEdge(int src, int dest, int weight)
        {

            Edges.Add(new Edge { Source = src, Destination = dest, Weight = weight });

        }

        public void KruskalMST() {

            // This is the Kruskal Algorithm 

            List<Edge> result = new List<Edge>(); // Store the MST
            Edges.Sort(); // Step 1 : Sort edges by weight ( Smallest First )

            //Creating an instance 
            DisjointSet ds = new DisjointSet(VerticesCount); // The smallest always get used first 

            int edgeCount = 0;
            int i = 0;

            // Creating a DisjointSet - this helps with with ensuring the edges makes a cycler 
            while (edgeCount < VerticesCount - 1 && i < Edges.Count) {

                Edge nextEdge = Edges[i++];
                int x = ds.Find(nextEdge.Source);
                int y = ds.Find(nextEdge.Destination);

                // If including this edge doesnt cause a cycler 
                if (x != y ){ // if it connects two diffrent groups, x !- y 
                    result.Add(nextEdge); // 
                    ds.Union(x, y); // Merge the groups to ensure those nodes are now connected 

                }

            }
            
            // Display the MST
            Console.WriteLine("Edges in the Minimum Spanning Tree:");
            int totalWeight = 0;
            foreach (Edge edge in result)
            {
                Console.WriteLine($"{edge.Source} -- {edge.Destination} == {edge.Weight}");
                totalWeight += edge.Weight;
            }

            Console.WriteLine($"Total weight of MST: {totalWeight}");

        }

    }
}
