
namespace LeetCodeProblems;
public class LRUCache
{
    private Dictionary<int, LinkedListNode<(int key, int value)>> map = new();
    private LinkedList<(int key, int value)> val = new();

    private int cap;

    public LRUCache(int capacity)
    {
        cap = capacity;
    }

    public int Get(int key)
    {
        if (!map.ContainsKey(key))
        {
            return -1;
        }
        val.Remove(map[key]);
        val.AddFirst(map[key]);

        return map[key].Value.value;
    }

    public void Put(int key, int value)
    {
        if (!map.ContainsKey(key) && map.Count >= cap)
        {
            map.Remove(val.Last.Value.key);
            val.Remove(val.Last);
        }

        var existingNode = map.GetValueOrDefault(key);
        if (existingNode != null)
        {
            val.Remove(existingNode);
        }

        val.AddFirst((key, value));
        map[key] = val.First;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */