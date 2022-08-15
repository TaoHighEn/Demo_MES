namespace Demo_MES_Core
{
    public class insertion_sort
    {
        internal void InsertionSort()
        {
            int[] array = { 1, 10, 5, 3, 2, 8, 7, 9 };
            for (int i = 1; i < array.Length; i++)
            {
                int tmp = array[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j] > tmp)
                    {
                        array[j + 1] = array[j];
                        if (j == 0)
                        {
                            array[0] = tmp;
                            break;
                        }
                    }
                    else
                    {
                        array[j + 1] = tmp;
                        break;
                    }
                }
            }
        }

    }
}
