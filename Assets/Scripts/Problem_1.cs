using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_1 : MonoBehaviour
{
    //Call your custom functions and print out the returns values of boxes 12,4 and 13.5f by 1.3f.
    //You should have 48 and 17.55 as your return print outs. 
    void Start()
    {
        print("The perimeter of a 12 by 4 box is: " + Perimeter(12, 4));
        print("The perimeter of a 13.5f by 1.3f box is: " + Perimeter(13.5f, 1.3f));
    }

    //Part 1: 
    //Create a function called Perimeter that takes in two parameters of int length and int width
    //Calculate the perimeter of the box and return the value as an int.

    int Perimeter(int a, int b)
    {
        int p = 2 * (a + b);
        return p;
    }


    //Part 2: 
    //Overload the function by creating a float version of the same function 
    float Perimeter(float a, float b)
    {
        float p = 2f * (a + b);
        return p;
    }
}
