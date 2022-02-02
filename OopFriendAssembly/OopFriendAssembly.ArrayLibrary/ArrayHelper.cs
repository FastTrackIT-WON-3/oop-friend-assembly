namespace OopFriendAssembly.ArrayLibrary
{
    public static class ArrayHelper
    {
        internal static int[] Clone(int[] array)
        {
            if (array is null || array.Length == 0)
            {
                return new int[0];
            }

            int[] clone = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                clone[i] = array[i];
            }

            return clone;
        }

        public static int[] BubbleSort(int[] array, SortOrder sortOrder)
        {
            int[] result = Clone(array);

            bool weHadSwaps;
            do
            {
                weHadSwaps = false;
                for (int i = 0; i < result.Length - 1; i++)
                {
                    bool areElementsInCorrectOrder = true;
                    switch (sortOrder)
                    {
                        case SortOrder.Descending:
                            areElementsInCorrectOrder = result[i] > result[i + 1];
                            break;

                        case SortOrder.Ascending:
                        default:
                            areElementsInCorrectOrder = result[i] < result[i + 1];
                            break;
                    }

                    if (!areElementsInCorrectOrder)
                    {
                        int temp = result[i];
                        result[i] = result[i + 1];
                        result[i + 1] = temp;

                        weHadSwaps = true;
                        break;
                    }
                }
            }
            while (weHadSwaps);

            return result;
        }

        public static int[] SelectionSort(int[] array, SortOrder sortOrder)
        {
            int[] result = Clone(array);

            for (int i = 0; i < result.Length - 1; i++)
            {
                // sa aduc pe result[i] minimul din sub-sirul result[i+1] => capat
                for (int j = i + 1; j < result.Length; j++)
                {
                    bool areElementsInCorrectOrder = true;
                    switch (sortOrder)
                    {
                        case SortOrder.Descending:
                            areElementsInCorrectOrder = result[i] > result[j];
                            break;

                        case SortOrder.Ascending:
                        default:
                            areElementsInCorrectOrder = result[i] < result[j];
                            break;
                    }

                    if (!areElementsInCorrectOrder)
                    {
                        // swap: result[i] = result[j];
                        int temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            return result;
        }
    }
}
