using UnityEngine;
using GameData;

public class MovingCube : MonoBehaviour
{
    private Vector3 _newPossition;
    private float _startY;

    private void Awake()
    {
        _startY = transform.position.y;
    }

    private void FixedUpdate()
    {
        DeleteCube();
        MovementCube();
    }
    
    private void MovementCube( )
    {      
       _newPossition = new Vector3(transform.position.x, _startY - PlayerData.instance.distance, transform.position.z);
       transform.position = Vector3.Lerp(transform.position, _newPossition, PlayerData.instance.speed * Time.deltaTime);
    }

    private void DeleteCube()
    {     
       if (transform.position == _newPossition)      
            Destroy(gameObject);     
    }
}
