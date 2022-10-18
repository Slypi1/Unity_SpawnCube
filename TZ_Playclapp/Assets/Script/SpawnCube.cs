using UnityEngine;
using GameData;

public class SpawnCube : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _cube;

     private float _spawnTime;

    private void Awake()
    {
        _spawnTime = 6;
    }
    private void Update()
    {
        RepeatCube();
    }

    private void RepeatCube()
    {       
        if (_spawnTime < 0 )
        {
            CreatingCube();
            _spawnTime = PlayerData.instance.timeCreationCube;
        }
        else if (_spawnTime != 0)
             _spawnTime -= Time.deltaTime;           
    }

    private void CreatingCube()
    {
        Instantiate(_cube, _spawnPoint.position, Quaternion.identity);
    }      
}
