# Minimum Spanning Tree Demo (Kruskal’s Algorithm)

This C# console application demonstrates how to find a **Minimum Spanning Tree (MST)** in a **weighted, connected, undirected graph** using **Kruskal’s Algorithm**.
It uses the **Disjoint Set (Union-Find)** data structure to efficiently detect and avoid cycles while connecting all vertices with the minimum total weight.

---

## What Is a Minimum Spanning Tree?

A **Minimum Spanning Tree (MST)** is a subset of the edges in a graph that:

* Connects **all vertices** together,
* Has **no cycles** (no circular paths),
* And has the **minimum possible total edge weight**.

Example use cases:

* Network design (like connecting cities or routers),
* Reducing road or cable construction costs,
* Clustering and path optimization.

---

## How Kruskal’s Algorithm Works

Kruskal’s algorithm builds the MST by:

1. Sorting all edges by their weight (lowest first),
2. Picking the smallest edge that **does not create a cycle**,
3. Repeating until all vertices are connected.

The **Disjoint Set (Union-Find)** structure is used to quickly check if two vertices are already connected (to avoid cycles).

---

## Project Structure

```
MinimumSpanningTreeDemo/
│
├── Edge.cs           # Represents an edge with source, destination, and weight
├── DisjointSet.cs    # Union-Find structure for cycle detection
├── Graph.cs          # Contains all vertices, edges, and the KruskalMST method
└── Program.cs        # Entry point — creates the graph and runs the algorithm
```

---

## Key Classes Explained

### **1. Edge**

Represents a connection between two vertices with a specific weight.
Implements `IComparable` so edges can be sorted by weight.

### **2. DisjointSet (Union-Find)**

Manages groups of connected vertices and prevents cycles using:

* **Find()** → Finds the root of a vertex.
* **Union()** → Merges two sets by rank (height) to keep lookups fast.

### **3. Graph**

Holds all vertices and edges and runs the **KruskalMST()** method, which:

* Sorts all edges by weight,
* Selects the smallest valid edges,
* Builds and prints the MST and its total weight.

---

## Example Code (Main Method)

```csharp
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
    }
}
```

---

## Sample Output

```
Edges in the Minimum Spanning Tree:
2 -- 3 == 4
0 -- 3 == 5
0 -- 1 == 10
Total weight of MST: 19
```

---

## Visual Example

Graph before running the algorithm:

```
   (0)
  / | \
10 6  5
 /  |   \
(1) |   (3)
 \  |   /
  \ |  /
   (2)
    4
```

After Kruskal’s algorithm (MST):

```
   0
  / \
 5   10
/     \
3 ----- 2
   (4)
```

Total weight = **19**

---

## Requirements

* **.NET 6 or later**
* Visual Studio / VS Code

---

## How to Run

1. Clone this repository:

   ```bash
   git clone https://github.com/minermikey/MinimumSpanningTreeDemo.git
   ```
2. Navigate to the project folder:

   ```bash
   cd MinimumSpanningTreeDemo
   ```
3. Run the project:

   ```bash
   dotnet run
   ```


This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.
