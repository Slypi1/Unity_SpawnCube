using UnityEngine;
using TMPro;

namespace GameData
{
    public class PlayerData : MonoBehaviour
    {
        [SerializeField] private TMP_InputField _timeCreationCubeIF;
        [SerializeField] private TMP_InputField _speedIF;
        [SerializeField] private TMP_InputField _distanceIF;


        [HideInInspector] public float timeCreationCube;
        [HideInInspector] public float speed;
        [HideInInspector] public float distance;

        static public PlayerData instance;

        private void Awake()
        {
            instance = GetComponent<PlayerData>();
        }

        private void Update()
        {
            TimerCreationCube();
            SpeedCube();
            DistanceCube();
        }

        private void TimerCreationCube()
        {
            if (float.TryParse(_timeCreationCubeIF.text, out float time))
                timeCreationCube = float.Parse(_timeCreationCubeIF.text);
        }

        private void SpeedCube()
        {
            if (float.TryParse(_speedIF.text, out float sp))
                speed = float.Parse(_speedIF.text);
        }

        private void DistanceCube()
        {
            if (float.TryParse(_distanceIF.text, out float dis))
                distance = float.Parse(_distanceIF.text);
        }
    }
}
