using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Player : MonoBehaviour
{
    Vector2 _currentPosition, _nextPosition;
    Transform _trans;
    [SerializeField] private Board _Board = new();
    [SerializeField] Player _player;
    private string playerRole;
    



    // Start is called before the first frame update
    void Start()
    {
        PlayerRole();
        _Board._PlayerRole.text = "Player1's role: " + playerRole;
    }


    public void MoveToLocation()
    {
        _currentPosition = new Vector2(_Board._Cities[16].position.x, _Board._Cities[16].position.y);
        _nextPosition = new Vector2(_Board._Cities[15].position.x, _Board._Cities[15].position.y);
        transform.position = Vector2.Lerp(_currentPosition, _nextPosition, 1f);
    }

    public void TreatDiease()
    {
        PlayerRole();
        if (playerRole == "Medic")
        {
            GameObject[] Localinfections = GameObject.FindGameObjectsWithTag("LocalInfection1");
           foreach(GameObject infections in Localinfections)
                GameObject.Destroy(infections);
            _Board.Infection[15] = 0;
            return;
        }

        if (_Board.Infection[15] <= 1)
        {
            print("Works");
            _Board.Infection[15] = _Board.Infection[15] - 1;
            Destroy(GameObject.Find("Green Disease Cube (Clone)"));

        }

        if (_Board.Infection[15] <= 2)
        {
            print("Works");

            _Board.Infection[15] -= 1;
            Destroy(GameObject.Find("Green Disease Cube (2)(Clone)"));
        }
                if (_Board.Infection[8] == 3)
                {
                    print("Works");

                    _Board.Infection[15] = _Board.Infection[15] - 1;
                    Destroy(GameObject.Find("Green Disease Cube (3)(Clone)"));
                  
        }

                }



       
            

        public void PlayerRole()
    {
        playerRole = "Medic";
    }



    // Update is called once per frame
    void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                MoveToLocation();
                Invoke("TreatDiease", 1.5f);
                _Board.AddDieaseCubeRand();
        }

    }
    }
