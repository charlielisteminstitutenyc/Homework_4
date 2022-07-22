using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_4 : MonoBehaviour
{
    //Connect this Script to Game Object Named Part_4,get the Transfom component
    //of Part_4, Part_4_Child using either transform.Get or transform.Find and the
    //transfrom of Part_4_GameObject using GameObject.Find
    //Using transform.name pass the name and position values of each of the Game Objects
    //to PrintOutNameAndPosition. 
    //You should have the results of Part_4, 0,0,0, Part_4_Child -5,-5,-5 and Part_4_GameObject, 5,5,5
    Transform etransform;
    Transform Lbozo;
    Transform TaketheLloser;
    void Start()
    {

        TaketheLloser = GameObject.Find("Part_4").GetComponent<Transform>();
        PrintOutNameAndPosition(TaketheLloser.name, TaketheLloser.position);
        etransform = GameObject.Find("Part_4_Child").GetComponent<Transform>();
        PrintOutNameAndPosition(etransform.name, etransform.position);
        Lbozo = GameObject.Find("Part_4_GameObject").GetComponent<Transform>();
        PrintOutNameAndPosition(Lbozo.name, Lbozo.position);
    }

    //Prints out the name and the position of the variables
    private void PrintOutNameAndPosition(string name, Vector3 pos)
    {
        print(name + " " + pos);
    }

}
