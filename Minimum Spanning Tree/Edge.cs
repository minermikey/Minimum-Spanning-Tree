namespace MinimumSpanningTree { 


public class Edge() : IComparable<Edge>
    {
        // Source is the starting node 
        // Destinatin is the end node 
        // Weight is the distance between them. 
        public int Source, Destination, Weight;

        // This compares to help sort weight from smalleset to largest ( Distance from smallest to biggest )
        public int CompareTo(Edge other) {
            return Weight.CompareTo(other.Weight);
        }

    }

}