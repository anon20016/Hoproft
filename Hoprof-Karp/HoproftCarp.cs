using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class HoproftCarp
    {
        private static List<bool> used;
        private static List<Nullable<int>> matching;
        private static List<List<int> > graph;
        private static List<int> first, second;
        private static int N;
        private static List<int> endings, t, q;


        public static List<Tuple<int, int > > Solve(List<List<int> > g)
        {
            used = new List<bool>(g.Count);
            graph = g;
            N = g.Count;

            Divide();

            endings = new List<int>();
            matching = new List<Nullable<int>>();
            dist = new List<int>();
            for (int i = 0; i < N; i++)
            {
                used.Add(false);
                matching.Add(null);
                dist.Add(0);
            }

            while (Check())
            {
                for (int i = 0; i < N; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < endings.Count; i++)
                {
                    var w = dfs(endings[i]);
                    if (w != null)
                    {
                        foreach (var d in w)
                        {
                            matching[d.Item1] = d.Item2;
                            matching[d.Item2] = d.Item1;
                        }
                    }
                }
            }
            List<Tuple<int, int> > result = new List<Tuple<int, int>>();
            foreach(var i in first)
            {
                if (matching[i] != null)
                {
                    result.Add(new Tuple<int, int>(i + 1, (int)matching[i] + 1));
                }
            }
            return result;
        }

        private static void Divide()
        {
            first = new List<int>();
            second = new List<int>();
            Queue<int> q = new Queue<int>();
            while (first.Count + second.Count != N)
            {
                for (int i = 0; i < N; i++)
                {
                    if (!first.Contains(i) && !second.Contains(i))
                    {
                        q.Enqueue(i);
                        first.Add(i);
                        break;
                    }
                }
                
                while (q.Count > 0)
                {
                    int t = q.Dequeue();
                    for (int i = 0; i < graph[t].Count; i++)
                    {
                        if (!first.Contains(graph[t][i]) && !second.Contains(graph[t][i]))
                        {
                            if (first.Contains(t))
                            {
                                second.Add(graph[t][i]);
                            }
                            else
                            {
                                first.Add(graph[t][i]);
                            }
                            q.Enqueue(graph[t][i]);
                        }
                        else
                        {
                            if (first.Contains(t) && first.Contains(graph[t][i]))
                            {
                                throw new ArgumentException("No good graph");
                            }
                            if (second.Contains(t) && second.Contains(graph[t][i]))
                            {
                                throw new ArgumentException("No good graph");
                            }
                        }
                    }
                }
            }
        }

        private static List<int> dist;

        private static bool Check()
        {
            for (int i = 0; i < N; i++)
            {
                dist[i] = -100;
            }
            q = new List<int>();
            t = new List<int>();
            foreach (var i in first)
            {
                if (matching[i] == null)
                {
                    dist[i] = 0;
                    q.Add(i);
                }
            }
            endings.Clear();
            while (q.Count > 0)
            {
                while (q.Count > 0)
                {
                    int s = q[0];
                    q.RemoveAt(0);
                    foreach (var u in graph[s])
                    {
                        if (dist[u] == -100)
                        {
                            dist[u] = dist[s] + 1;
                            if (matching[u] == null)
                            {
                                endings.Add(u);
                            }
                            else
                            {
                                t.Add(u);
                            }
                        }
                    }
                }
                if (endings.Count > 0)
                {
                    return true;
                }
                while (t.Count >0)
                {
                    int p = t[0];
                    t.RemoveAt(0);
                    int pp = (int)matching[p];
                    dist[pp] = dist[p] + 1;
                    q.Add(pp);
                }
            }
            return false;
        }

        private static List<Tuple<int, int>> dfs(int x)
        {
            if (!used[x])
            {
                used[x] = true;
                foreach (var i in graph[x])
                {
                    if (dist[x] == dist[i] + 1 && !used[i] && dist[i] == 0)
                    {
                        used[i] = true;
                        List<Tuple<int, int>> temp = new List<Tuple<int, int>>();
                        temp.Add(new Tuple<int, int>(i, x));
                        return temp;
                    }
                    var r = dfs(i);
                    if (r != null)
                    {
                        r.Add(new Tuple<int, int>(i, x));
                        return r;
                    }

                }
            }
            return null;
        }
    }
}
