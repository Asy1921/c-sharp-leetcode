// 380. Insert Delete GetRandom O(1)

// Medium
// Topics
// Companies
// Implement the RandomizedSet class:

// RandomizedSet() Initializes the RandomizedSet object.
// bool insert(int val) Inserts an item val into the set if not present. Returns true if the item was not present, false otherwise.
// bool remove(int val) Removes an item val from the set if present. Returns true if the item was present, false otherwise.
// int getRandom() Returns a random element from the current set of elements (it's guaranteed that at least one element exists when this method is called). Each element must have the same probability of being returned.
// You must implement the functions of the class such that each function works in average O(1) time complexity.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public class RandomizedSet
    {
        private Random r;

        private Dictionary<int, int> map;
        private List<int> values;
        public RandomizedSet()
        {
            r = new Random();
            map = new Dictionary<int, int>();
            values = new List<int>();

        }

        public bool Insert(int val)
        {
            if (map.ContainsKey(val))
            {
                return false;
            }
            values.Add(val);
            map[val] = values.Count - 1;
            return true;
        }

        public bool Remove(int val)
        {
            if (!map.ContainsKey(val))
            {
                return false;
            }
            var currentIndex = map[val];
            var lastIndex = values.Count - 1;
            values[currentIndex] = values[lastIndex];
            map[values[currentIndex]] = currentIndex;
            values.RemoveAt(lastIndex);
            map.Remove(val);

            return true;
        }

        public int GetRandom()
        {
            var randomIndex = r.Next(0, values.Count);
            return values[randomIndex];
        }
    }
}