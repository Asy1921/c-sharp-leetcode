using System;
using System.Collections.Generic;

namespace LeetCodeProblems;
public partial class LCProblems
{
    public static int NumBusesToDestination(int[][] routes, int s, int t)
    {
        if (s == t)
            return 0;

        Dictionary<int, HashSet<int>> stopToRoutes = new Dictionary<int, HashSet<int>>();

        for (int i = 0; i < routes.Length; i++)
        {
            foreach (int stop in routes[i])
            {
                if (!stopToRoutes.ContainsKey(stop))
                    stopToRoutes[stop] = new HashSet<int>();

                stopToRoutes[stop].Add(i);
            }
        }

        HashSet<int> visitedRoutes = new HashSet<int>();
        Queue<(int stop, int numBuses)> queue = new Queue<(int stop, int numBuses)>();
        queue.Enqueue((s, 0));

        while (queue.Count > 0)
        {
            var (currentStop, numBuses) = queue.Dequeue();

            foreach (int routeIndex in stopToRoutes[currentStop])
            {
                if (visitedRoutes.Contains(routeIndex))
                    continue;

                visitedRoutes.Add(routeIndex);

                foreach (int nextStop in routes[routeIndex])
                {
                    if (nextStop == t)
                        return numBuses + 1;

                    queue.Enqueue((nextStop, numBuses + 1));
                }
            }
        }

        return -1;
    }
}

