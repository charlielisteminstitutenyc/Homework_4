using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_2 : MonoBehaviour
{
    //Call your function using an int[] array = new int[10]{1,2,3,4,5,6,7,8,9,10};
    //Your return values should be a List<int> that holds {1,3,5,7,9}
    void Start()
    {
        int[] demo = loser(new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        for (int i = 0; i < demo.Length; i++)
        {
            print(demo[i]);
        }
    }

    int[] loser(int[] arr)
    {
        int[] finale = new int[arr.Length / 2];
        for (int i = 0; i < finale.Length; i++)
        {
            finale[i] = arr[i * 2];
        }
        return finale;
    }

}
