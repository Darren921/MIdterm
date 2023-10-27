using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class Cities : MonoBehaviour
{
 

    public Board _Board = new();

    void Start()
    {
        //updating the infection lv and visual on start 
        CheckInfectionLV();

    }

    //Updating and creating diease cubes
    public void CheckInfectionLV()
    {
        if (_Board.Infection[1] >= 1)
        {
              Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[1].position.x + 0.35f, _Board._Cities[1].position.y + 0.25f), Quaternion.identity);
            
        }
        if (_Board.Infection[1] >= 2)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[1].position.x + 0.35f, _Board._Cities[1].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[1] == 3)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[1].position.x + 0.35f, _Board._Cities[1].position.y + 0.87f), Quaternion.identity);
        }
                

        if (_Board.Infection[2] >= 1)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[2].position.x + 0.35f, _Board._Cities[2].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[2] >= 2)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[2].position.x + 0.35f, _Board._Cities[2].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[2] == 3)
        { 
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[2].position.x + 0.35f, _Board._Cities[2].position.y + 0.87f), Quaternion.identity);
        }

        if (_Board.Infection[3] >= 1)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[3].position.x + 0.35f, _Board._Cities[3].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[3] >= 2)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[3].position.x + 0.35f, _Board._Cities[3].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[3] == 3)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[3].position.x + 0.35f, _Board._Cities[3].position.y + 0.87f), Quaternion.identity);
        }

        if (_Board.Infection[4] >= 1)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[4].position.x + 0.35f, _Board._Cities[4].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[4] >= 2)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[4].position.x + 0.35f, _Board._Cities[4].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[4] == 3)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[4].position.x + 0.35f, _Board._Cities[4].position.y + 0.87f), Quaternion.identity);
        }

        if (_Board.Infection[5] >= 1)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[5].position.x + 0.35f, _Board._Cities[5].position.y + 0.25f), Quaternion.identity);
        }

        if (_Board.Infection[5] >= 2)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[5].position.x + 0.35f, _Board._Cities[5].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[5] == 3)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[5].position.x + 0.35f, _Board._Cities[5].position.y + 0.87f), Quaternion.identity);
        }

        if (_Board.Infection[6] >= 1)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[6].position.x + 0.35f, _Board._Cities[6].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[6] >= 2)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[6].position.x + 0.35f, _Board._Cities[6].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[6] == 3)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[6].position.x + 0.35f, _Board._Cities[6].position.y + 0.87f), Quaternion.identity);
        }

        if (_Board.Infection[7] >= 1)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[7].position.x + 0.35f, _Board._Cities[7].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[7] >= 2)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[7].position.x + 0.35f, _Board._Cities[7].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[7] == 3)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[7].position.x + 0.35f, _Board._Cities[7].position.y + 0.87f), Quaternion.identity);
        }


        if (_Board.Infection[8] >= 1)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[8].position.x + 0.35f, _Board._Cities[8].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[8] >= 2)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[8].position.x + 0.35f, _Board._Cities[8].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[8] == 3)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[8].position.x + 0.35f, _Board._Cities[8].position.y + 0.87f), Quaternion.identity);
        }


        if (_Board.Infection[9] >= 1)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[9].position.x + 0.35f, _Board._Cities[9].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[9] >= 2)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[9].position.x + 0.35f, _Board._Cities[9].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[9] == 3)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[9].position.x + 0.35f, _Board._Cities[9].position.y + 0.87f), Quaternion.identity);
        }


        if (_Board.Infection[10] >= 1)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[10].position.x + 0.35f, _Board._Cities[10].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[10] >= 2)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[10].position.x + 0.35f, _Board._Cities[10].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[10] == 3)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[10].position.x + 0.35f, _Board._Cities[10].position.y + 0.87f), Quaternion.identity);
        }


        if (_Board.Infection[11] >= 1)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[11].position.x + 0.35f, _Board._Cities[11].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[11] >= 2)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[11].position.x + 0.35f, _Board._Cities[11].position.y + .56f), Quaternion.identity);
        }

        if (_Board.Infection[11] == 3)
        {
            Instantiate(_Board.infectionSquares[2], new Vector2(_Board._Cities[11].position.x + 0.35f, _Board._Cities[11].position.y + 0.87f), Quaternion.identity);
        }

        if (_Board.Infection[12] >= 1)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[12].position.x + 0.35f, _Board._Cities[12].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[12] >= 2)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[12].position.x + 0.35f, _Board._Cities[12].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[12] == 3)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[12].position.x + 0.35f, _Board._Cities[12].position.y + 0.87f), Quaternion.identity);
        }

        if (_Board.Infection[13] >= 1)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[13].position.x + 0.35f, _Board._Cities[13].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[13] >= 2)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[13].position.x + 0.35f, _Board._Cities[13].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[13] == 3)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[13].position.x + 0.35f, _Board._Cities[13].position.y + 0.87f), Quaternion.identity);
        }


        if (_Board.Infection[14] >= 1)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[14].position.x + 0.35f, _Board._Cities[14].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[14] >= 2)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[14].position.x + 0.35f, _Board._Cities[14].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[14] == 3)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[14].position.x + 0.35f, _Board._Cities[14].position.y + 0.87f), Quaternion.identity);
        }

        if (_Board.Infection[15] >= 1)
        {
            var clone =Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[15].position.x + 0.35f, _Board._Cities[15].position.y + 0.25f), Quaternion.identity);
            clone.tag = "LocalInfection1";
        }
        if (_Board.Infection[15] >= 2)
        {
           var clone = Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[15].position.x + 0.35f, _Board._Cities[15].position.y + .56f), Quaternion.identity);
            clone.tag = "LocalInfection1";

        }
        if (_Board.Infection[15] == 3)
        {
            var clone = Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[15].position.x + 0.35f, _Board._Cities[15].position.y + 0.87f), Quaternion.identity);
            clone.tag = "LocalInfection1";

        }

        if (_Board.Infection[16] >= 1)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[16].position.x + 0.35f, _Board._Cities[16].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[16] >= 2)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[16].position.x + 0.35f, _Board._Cities[16].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[16] == 3)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[16].position.x + 0.35f, _Board._Cities[16].position.y + 0.87f), Quaternion.identity);
        }

        if (_Board.Infection[17] >= 1)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[17].position.x + 0.35f, _Board._Cities[17].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[17] >= 2)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[17].position.x + 0.35f, _Board._Cities[17].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[17] == 3)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[17].position.x + 0.35f, _Board._Cities[17].position.y + 0.87f), Quaternion.identity);
        }

        if (_Board.Infection[18] >= 1)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[18].position.x + 0.35f, _Board._Cities[18].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[18] >= 2)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[18].position.x + 0.35f, _Board._Cities[18].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[18] == 3)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[18].position.x + 0.35f, _Board._Cities[18].position.y + 0.87f), Quaternion.identity);
        }

        if (_Board.Infection[19] >= 1)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[19].position.x + 0.35f, _Board._Cities[19].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[19] >= 2)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[19].position.x + 0.35f, _Board._Cities[19].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[19] == 3)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[19].position.x + 0.35f, _Board._Cities[19].position.y + 0.87f), Quaternion.identity);
        }

        if (_Board.Infection[20] >= 1)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[20].position.x + 0.35f, _Board._Cities[20].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[20] >= 2)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[20].position.x + 0.35f, _Board._Cities[20].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[20] == 3)
        {
            Instantiate(_Board.infectionSquares[0], new Vector2(_Board._Cities[20].position.x + 0.35f, _Board._Cities[20].position.y + 0.87f), Quaternion.identity);
        }

        if (_Board.Infection[0] >= 1)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[0].position.x + 0.35f, _Board._Cities[0].position.y + 0.25f), Quaternion.identity);
        }
        if (_Board.Infection[0] >= 2)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[0].position.x + 0.35f, _Board._Cities[0].position.y + .56f), Quaternion.identity);
        }
        if (_Board.Infection[0] == 3)
        {
            Instantiate(_Board.infectionSquares[1], new Vector2(_Board._Cities[0].position.x + 0.35f, _Board._Cities[0].position.y + 0.87f), Quaternion.identity);
        }
            
      
        
    }

    

    // Update is called once per frame
    void Update()
    {
        //this occurs at the end of the players "turn" 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Invoke("CheckInfectionLV", 2f);
        }
    }
}
