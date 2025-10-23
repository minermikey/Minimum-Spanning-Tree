/*

    WE'll be looking into Minimum spanning trees : 

    This is used with special kinds of graphs that are 
    Weighted  : Each Connection has a number showing its cost, time or distance 
    Connectted : You can get from one point to any other 
    Undirectinoal : Connection goes both ways 

    Examples : 

    Weighted Graphs Visual Presenenation :
                    (A)
                   / \
                4/   \2
                /     \
               (B)----(C)
                    3

    Connected Graphs : 

              (A)
              / \
             /   \
            (B)---(C)
            \
            \
            (D)

    Unidirectional :

     A —— B


     A drawable example of this would be : 

     4
  A ----- B
  | \     |
  |  \    |
 2|   \3  |5
  |    \  |
  |     \ |
  C ----- D
      6

Finding the shortest distance : 

   A
   |
  (2)
   |
   C
    \
   (3)\
      \
       B
        \
       (5)
         \
          D

*/


namespace MinimumSpanningTree { 

class Program
    {
        static void Main()
        {
            Graph g = new Graph(4); // 4 vertices: 0, 1, 2, 3
            g.AddEdge(0, 1, 10);
            g.AddEdge(0, 2, 6);
            g.AddEdge(0, 3, 5);
            g.AddEdge(1, 3, 15);
            g.AddEdge(2, 3, 4);

            g.KruskalMST();

            /*
            
            Visual representation 

                (10)
                0 ------ 1
                | \      
                |  \     
                |   \    
                (6) (5)  
                |     \   
                2 ---- 3
                \    /
                \  /
                (4)

            */
        }
    }

}
