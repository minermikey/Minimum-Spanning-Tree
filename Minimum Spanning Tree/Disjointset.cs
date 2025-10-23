namespace MinimumSpanningTree {

    // This class is important as it help us find cycles, which stops us from looping 
    // in this example ill use cities as an explanation for everyone to have a better understanding on what is happening 
    // if we are buliding a city we dont want eveyrhting corrected to each other 

    public class DisjointSet{

        // This is the parents or representative of the group 
        private int[] parent;
        // This will help keep the tree short when when merging groups 
        private int[] rank;

        public DisjointSet(int size)
        {
            parent = new int[size];
            rank = new int[size];
            for (int i = 0; i < size; i++)
                parent[i] = i;
        }

        public int Find(int i) { 
        //Finds the leader (root) of the group that vertex i belongs to.
            if (i != parent[i])
                parent[i] = Find(parent[i]); // Path compression : means it makes the structure flatter and faster next time.
            return parent[i];

        }

       public void Union(int x, int y)
        {

            // It attaches the smaller tree to the bigger one (based on rank), to keep things efficient.

            int xRoot = Find(x); // tells the root leader the set that x belongs too. 
            int yRoot = Find(y); // tell the root leader the set the y belongs too 

            if (xRoot == yRoot) // if x= y then xRoot and yRoot are connected 
                return;

            if (rank[xRoot] < rank[yRoot]) // Rank is luje the height of the tree for efficientcy 
                parent[xRoot] = yRoot; // if x's tree is smaller we attach it under y's tree - parents[xRoot] = yRoot
            else if (rank[xRoot] > rank[yRoot]) // if x's tree is larger we attach it attach it ontop of y's - parent[yRoot] = xRoot
                parent[yRoot] = xRoot;
            else
            {
                // if both trees have the same rank we attach y under x 
                // we then increase the rank of x's root by 1
                parent[yRoot] = xRoot;
                rank[xRoot]++;
            }
        }


    }
}