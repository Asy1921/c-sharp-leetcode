// 706.Design HashMap
// Easy
// 4.8K
// 421
// Companies
// Design a HashMap without using any built-in hash table libraries.

// Implement the MyHashMap class:

// MyHashMap() initializes the object with an empty map.
// void put(int key, int value) inserts a (key, value) pair into the HashMap.If the key already exists in the map, update the corresponding value.
// int get(int key) returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key.
// void remove(key) removes the key and its corresponding value if the map contains the mapping for the key.


namespace LeetCodeProblems;
public class MyHashMap
{
    public List<(int key, int value)> map;
    public MyHashMap()
    {
        map = new List<(int key, int value)>();
    }

    public void Put(int key, int value)
    {
        if (map.Where(x => x.key == key).Any())
        {
            var row = map.Where(x => x.key == key).FirstOrDefault();
            map.Remove(row);
            map.Add((key, value));
        }
        else
        {
            map.Add((key, value));
        }
    }

    public int Get(int key)
    {
        if (map.Where(x => x.key == key).Any())
        {
            return map.Where(x => x.key == key).FirstOrDefault().value;
        }
        else
        {
            return -1;
        }
    }

    public void Remove(int key)
    {
        map.Remove(map.Where(x => x.key == key).FirstOrDefault());
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
