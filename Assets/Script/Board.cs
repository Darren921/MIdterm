using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Board : MonoBehaviour
{
    //creating a list for the different postions of the cities
    public Transform[] _Cities = new Transform[21];
    //creating a list for the different lv of infection of the cities
    public int[] Infection = new int[21];
    //creating a list for the different disease cubes in order to easily instantiate
    public GameObject[] infectionSquares;
    //to display the player role in text
    public TextMeshProUGUI _PlayerRole;
    //to hold the random value generated to search of a city 
    public static int RandCity;

    void Start()
    {
    }

    //Adding disease cubes at the end of a "turn"
    public void AddDieaseCubeRand()
    {
        //randomly getting cities to add cubes to 
        RandCity = Random.Range(0, 20);
        Infection[RandCity] = Infection[RandCity] + 1;
        RandCity = Random.Range(0, 20);
        Infection[RandCity] = Infection[RandCity] + 1;
        //making sure the amount of cubes in a doesn't go higher than 3
        for (int i = 0; i < Infection.Length; i++) 
        {
            if (Infection[i] >= 3)
            {
                Infection[i] = 3;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
