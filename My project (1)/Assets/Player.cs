using UnityEngine;

public class Player : MonoBehaviour
{   
    public Rigidbody2D _rigidbody;
    public GameObject Player1;
    public float _speed;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MovePlayer(){//This is the method used for player movement.

        Vector3 movePosition =  Vector3.zero;

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            
            movePosition.y += 1; //The Player moves upwards
        }

        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){

            movePosition.y -=1; //The Player moves downwards
        }
        
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){

            movePosition.x -=1; //The Player moves left
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){

            movePosition.x +=1; //The Player moves right
        }

        Player1.transform.position += movePosition.normalized* Time.deltaTime;

        _rigidbody.linearVelocity = movePosition.normalized*_speed;

    }
}
