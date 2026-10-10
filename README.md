# Algorithms & Data Structures Portfolio — C#

**Hakan Korkmaz · Computer Science · Manchester Metropolitan University**

Four academic console applications connecting foundational algorithms and data structures with practical scenarios: managing emergency calls, organising video-game records, selecting aid supplies, and modelling station connections.

## Explore the implementations

| Project | Scenario | Technical focus | Start here |
| --- | --- | --- | --- |
| [Emergency call queue](assessment1/ADS_Assess1) | Store and dispatch calls, inspect severity | Circular queue, FIFO operations, capacity handling, severity lookup | [EmergencyQueue.cs](assessment1/ADS_Assess1/EmergencyQueue.cs) |
| [Video-game catalogue](assessment2/ADSPortEx2) | Add, search, update and remove game records | Binary search trees, AVL insertion and removal, tree traversals | [AVLTree.cs](assessment2/ADSPortEx2/AVLTree.cs) · [BSTree.cs](assessment2/ADSPortEx2/BSTree.cs) |
| [Aid-item selection](assessment3/ADSPortEx3) | Sort records and select supplies within a weight limit | Generic QuickSort, IComparable, priority-to-weight greedy selection | [SortUtils.cs](assessment3/ADSPortEx3/SortUtils.cs) · [GreedyUtils.cs](assessment3/ADSPortEx3/GreedyUtils.cs) |
| [Station network](assessment4/ADSPortEx4) | Connect stations and inspect network statistics | Adjacency lists, directed weighted edges, average outbound connections and travel time | [Graph.cs](assessment4/ADSPortEx4/Graph.cs) · [GraphNode.cs](assessment4/ADSPortEx4/GraphNode.cs) |

## What this work demonstrates

- Translating scenario requirements into classes, data models and menu-driven operations.
- Implementing and using generic structures with comparisons and traversal logic.
- Connecting sorting with a constrained greedy selection strategy.
- Modelling network connections and computing descriptive metrics.

## Build and run

These are the original Visual Studio projects, targeting **.NET Framework 4.7.2**.

1. On Windows, use Visual Studio with the **.NET desktop development** workload and the .NET Framework 4.7.2 targeting pack.
2. Open the solution for the project you want to explore:
   - `assessment1/ADS_Assess1.sln`
   - `assessment2/ADSPortEx2.sln`
   - `assessment3/ADSPortEx3.sln`
   - `assessment4/ADSPortEx4.sln`
3. Restore NuGet packages where prompted, then build the solution.
4. Start the console application and follow its numbered menu.

The station-network project retains its original package configuration, including NUnit references. The original projects have not been migrated to modern cross-platform .NET.

## Suggested demonstrations

- **Queues:** add several calls with different severity levels; inspect the most severe call and dispatch the oldest call to compare severity lookup with FIFO order.
- **Trees:** add game records, compare traversal orders, inspect height and count, then update or remove an entry.
- **Sorting and greedy selection:** sort an integer or string array; add aid items with different weights and priorities, then select a load under a weight limit.
- **Graphs:** add stations and weighted connections, then inspect edge counts, average outbound connections, average travel time and direct connections.

## Scope and limitations

This repository preserves the submitted source as portfolio evidence. It is academic work, rather than production software.

- `BFS`, `DFS` and `FastestRoute` in `Graph.cs` remain unimplemented placeholders; graph traversal and route optimisation are not claimed as completed features.
- The greedy load selection is a heuristic and does not guarantee an optimal knapsack solution.
- Console input validation and boundary handling can be extended. For example, game release-year validation retains the original upper bound of 2025.
- Build and runtime behaviour were not revalidated for this publication because a compatible .NET Framework build environment was unavailable.

## Provenance

Developed by Hakan Korkmaz as university coursework using course-provided starter materials. Original scaffold comments and implementation code are preserved; this repository does not claim that every line was authored independently from scratch.

Publication preparation added this guide and a `.gitignore`; GitHub Classroom invitation links, local metadata, generated binaries and full assessment reports are excluded. No blanket open-source licence is applied to the mixed coursework and starter materials.

[LinkedIn profile](https://www.linkedin.com/in/hakan-korkmaz06/)
