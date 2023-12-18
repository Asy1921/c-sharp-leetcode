//1436. Destination City
//Easy
//1.8K
//89
//Companies
//You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi. Return the destination city, that is, the city without any path outgoing to another city.

//It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
namespace LeetCodeProblems;

public partial class LCProblems {
    public string DestCity(IList<IList<string>> paths) {
        string curCity=paths.First().Last();
        while(paths.Where(x=>x.First()==curCity).Any())
        {
            curCity=paths.Where(x=>x.First()==curCity).First().Last();
        }

        return curCity;
        
    }
}
