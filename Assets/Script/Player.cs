using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 _currentPosition, _nextPosition;
    Transform _trans;
    [SerializeField] private Board _Board = new Board();
    [SerializeField] Player _player;
    private Cities _cities = new Cities();


    // Start is called before the first frame update
    void Start()
    {
    }


    public void MoveToLocation()
    {
        _currentPosition = new Vector2(_Board._Cities[9].position.x, _Board._Cities[9].position.y);
        _nextPosition = new Vector2(_Board._Cities[8].position.x, _Board._Cities[8].position.y);
        transform.position = Vector2.Lerp(_currentPosition, _nextPosition, 1f);
    }

    public void TreatDiease()
    {

        if (_Board.Infection[8] <= 1)
        {
            print("Works");
            _Board.Infection[8] = _Board.Infection[8] - 1;
            Destroy(GameObject.Find("Green Disease Cube (Clone)"));

        }

        if (_Board.Infection[8] <= 2)
        {
            print("Works");

            _Board.Infection[8] -= 1;
            Destroy(GameObject.Find("Green Disease Cube (2)(Clone)"));
        }
                if (_Board.Infection[8] == 3)
                {
                    print("Works");

                    _Board.Infection[8] = _Board.Infection[8] - 1;
                    Destroy(GameObject.Find("Green Disease Cube (3)(Clone)"));
                }

                }

            

        


        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                MoveToLocation();
                Invoke("TreatDiease", 1f); 
            }
            if (Input.GetKeyDown(KeyCode.C) && (_cities.Updated = false))
            {
                _cities.CheckInfectionLV();
            }
        }
    }
