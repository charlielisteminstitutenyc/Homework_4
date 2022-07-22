using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_2 : MonoBehaviour
{
    //Call your function using an int[] array = new int[10]{1,2,3,4,5,6,7,8,9,10};
    //Your return values should be a List<int> that holds {1,3,5,7,9}
    void Start()
    {
        List<int> demo = OddOnlyOnes(new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        for (int i = 0; i < demo.Count; i++)
        {
            print(demo[i]);
        }
    }

    List<int> OddOnlyOnes(int[] arr)
    {
        List<int> finale = new List<int>();
        for (int i = 0; i < arr.Length; i= i + 2)
        {
            finale.Add(arr[i]);
        }
        return finale;
    }

}
