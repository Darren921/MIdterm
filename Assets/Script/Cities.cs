using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cities : MonoBehaviour
{
    int LvOfInfection;
    public Boolean Updated;
    // Start is called before the first frame update

    public Board _Board = new Board();

    void Start()
    {
        CheckInfectionLV();
    }

    public void CheckInfectionLV()
    {
        if (_Board.Infection[8] >= 1)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(-10.848f, -1.858f), Quaternion.identity);
            Updated = true;
            if (_Board.Infection[8] >= 2)
            {
                Instantiate(_Board.infectionSquares[1], new Vector2(-10.851f, -1.521f), Quaternion.identity);
                Updated = true;
                if (_Board.Infection[8] == 3)
                {
                    Instantiate(_Board.infectionSquares[2], new Vector2(-10.85f, -1.205f), Quaternion.identity);
                    Updated = true;
                }

            }

        }



    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
