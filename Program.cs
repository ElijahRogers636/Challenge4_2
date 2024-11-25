namespace Challenge4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new int[]{1,2,3,2,5,1,1,1,1,1,1,1,5};
            Dictionary<int, int> frequencies = FindFrequencies(input);
            PrintFreqDict(frequencies);
        }

        // If element of input array(key) is not in Dictionary frequencies add it assign its value to 1. else increment value of key value pair.
        static Dictionary<int, int> FindFrequencies(int[] input)
        {
            Dictionary<int, int> frequencies = new Dictionary<int, int>();

            foreach (int elem in input)
            {
                if (!frequencies.ContainsKey(elem))
                {
                    frequencies.Add(elem, 1);
                }
                else
                {
                    frequencies[elem]++;
                }
            }
            return frequencies;
        }

        // Prints the frequencies of each int in an dictionary
        static void PrintFreqDict(Dictionary<int, int> dict)
        {
            foreach (int elem in dict.Keys)
            {
                Console.WriteLine($"Number: { elem } Frequency: { dict.GetValueOrDefault(elem) } ");
            }
        }
    }
}
