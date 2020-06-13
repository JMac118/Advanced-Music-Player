using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPlayer;

namespace Sort
{
    class SongSort
    {
        public string[] MergeSort(string[] arr)
        {
            string[] left;
            string[] right;
            string[] result= null;
            int midPoint;

            //if theres only 1 in split then it is base case
            if (arr.Length<= 1) 
            {
                result = arr;
            }
            else
            {
                midPoint = arr.Length / 2;

                left = new string[midPoint];

                if(arr.Length % 2 == 0)
                {
                    right = new string[midPoint];
                }
                else
                {
                    right = new string[midPoint + 1];
                }

                for(int i = 0; i < midPoint; i++)
                {
                    left[i] = arr[i];
                }

                int x = 0;

                for(int i = midPoint; i < arr.Length; i++)
                {
                    right[x] = arr[i];
                    x++;
                }
                left = MergeSort(left);
                right = Merge(left, right);
                
            }
            return result;
        }

        private string[] Merge(string[] left, string[] right)
        {
            int resultLength = right.Length + left.Length;
            string[] result = new string[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while(indexLeft < left.Length || indexRight < right.Length)
            {
                if(indexLeft < left.Length && indexRight < right.Length)
                {
                    if ((String.CompareOrdinal(left[indexLeft], right[indexRight])) >= 0)
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                    
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }


        public Song[] MergeSortSong(Song[] arr)
        {
            Song[] left;
            Song[] right;
            Song[] result = null;
            int midPoint;

            //if theres only 1 in split then it is base case
            if (arr.Length <= 1)
            {
                result = arr;
            }
            else
            {
                midPoint = arr.Length / 2;

                left = new Song[midPoint];

                if (arr.Length % 2 == 0)
                {
                    right = new Song[midPoint];
                }
                else
                {
                    right = new Song[midPoint + 1];
                }

                for (int i = 0; i < midPoint; i++)
                {
                    left[i] = arr[i];
                }

                int x = 0;

                for (int i = midPoint; i < arr.Length; i++)
                {
                    right[x] = arr[i];
                    x++;
                }
                left = MergeSortSong(left);
                right = MergeSortSong(right);

                result = MergeSong(left, right);

            }
            return result;
        }

        private Song[] MergeSong(Song[] left, Song[] right)
        {
            int resultLength = right.Length + left.Length;
            Song[] result = new Song[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if ((String.CompareOrdinal(left[indexLeft].getSongName(), right[indexRight].getSongName())) <= 0)
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }

                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }


    
}