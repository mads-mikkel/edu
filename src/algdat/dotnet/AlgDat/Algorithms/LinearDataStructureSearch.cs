using System.ComponentModel.Design;

namespace Algorithms
{
    public interface ILinearDataStructureSearch<T>
    {
        int IterativeSearch(IEnumerable<T> data, T searchKey);
        int RecursiveSearch(IEnumerable<T> data, T searchKey, int startingIndex);
    }

    public class LinearDataStructureSearch
    {
    }

    public class LinearDataStructureSearch<T>: LinearDataStructureSearch, ILinearDataStructureSearch<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns>The index of the element that matches the search key, otherwise -1 is returned.</returns>
        public int IterativeSearch(IEnumerable<T> data, T searchKey)
        {
            for(int i = 0; i < data.Count(); i++)
            {
                if(data.ElementAt(i).Equals(searchKey))
                {
                    return i;
                }
            }
            return -1;
        }

        public int RecursiveSearch(IEnumerable<T> data, T searchKey, int startingIndex)
        {
            if(startingIndex >= data.Count())
                return -1;
            else if(data.ElementAt(startingIndex).Equals(searchKey))
                return startingIndex;
            else
                return RecursiveSearch(data, searchKey, ++startingIndex);
        }
    }
}