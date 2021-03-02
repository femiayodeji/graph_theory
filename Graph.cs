using System;
using System.Collections.Generic;

//adjacency List representation
public class Adjacency_List_Graph
{
    private LinkedList<int>[] _graph;
    
    public Adjacency_List_Graph(int vertices)
    {
         _graph = new LinkedList<int>[vertices]; 
         Initialize();  
    }

    private void Initialize(){
        for (int i = 0; i < _graph.Length; i++)
            _graph[i] = new LinkedList<int>();
    }

    public void AddEdge(int u, int v)
    {
        _graph[u].AddLast(v);
        _graph[v].AddLast(u);
    }

    public override string ToString()
    {
        string output = "";
        for(int i = 0; i < _graph.Length; i++)
        {
            output += $"Adjacent list of vertex {i}\n Head";
            foreach (var item in _graph[i])
            {
                output += $" -> {item}";                
            }
            output += "\n";
        }
        return output;
    }
}