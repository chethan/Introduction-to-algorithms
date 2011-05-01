using System.Collections.Generic;

namespace DynamicProgramming
{
    public static class Sequences
    {

        // Li=  max(all j < i) {Lj : A[i] > A[j] } + 1 
        public static int LongestIncreasingSubsequence(this List<int> elements)
        {
            var lengthsOfIncreasingSeqence = new List<int>();
            for (int current = 0; current < elements.Count; current++)
            {
                lengthsOfIncreasingSeqence.Add(1);
                for (int previous = 0; previous < current; previous++)
                {
                    if(elements[previous] < elements[current] && lengthsOfIncreasingSeqence[current] < (lengthsOfIncreasingSeqence[previous] + 1))
                        lengthsOfIncreasingSeqence[current] = lengthsOfIncreasingSeqence[previous] + 1;
                }
            }
            return lengthsOfIncreasingSeqence[elements.Count-1];
        }

        //TopCoder ZIG ZAG Problem
        public static int TogglingSubsequence(this List<int> elements)
        {
            var togglingSequence = new List<ToggleData>();
            for (var current = 0; current < elements.Count; current++)
            {
                togglingSequence.Add(new ToggleData(1,0,-1));
                for (var previous = 0; previous < current; previous++)
                {
                    var lastElement = elements[previous];
                    if (!togglingSequence[previous].DoesToggle(lastElement, elements[current])) continue;
                    var count = togglingSequence[previous].Count+1;
                    if (togglingSequence[current].Count< count)
                        togglingSequence[current] = new ToggleData(count,elements[current]-lastElement,previous);
                }
            }
            return togglingSequence[elements.Count-1].Count;
        }

        private class ToggleData
        {
            public int Count { get; private set; }
            private int Increasing { get; set; }
            private int LastElementIndex { get; set; }

            public ToggleData(int count,int increasing,int lastElement)
            {
                LastElementIndex = lastElement;
                Count = count;
                Increasing = increasing;
            }

            public bool DoesToggle(int prev, int current)
            {
                if (Increasing > 0) return prev > current;
                if (Increasing < 0) return prev < current;
                return true;
            }
        }
    }
}