using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = 5;
        _numSeedsPlanted = 0;
    }

    private void Update()
    {
        //Gets Keyboard Input, then translates the player sprite depending on speed. 
        if (Input.GetKey(KeyCode.W))
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))//Changed so that it doesn't update the plant UI to be as long as it is held
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        //Updates Number of Seeds to Preset Variables _NumSeedsLeft and _numSeedsPlanted.
        _numSeedsLeft = _numSeedsLeft - 1;
        _numSeedsPlanted = _numSeedsPlanted + 1;
        if (_numSeedsPlanted <= 5)
        {
            Instantiate(_plantPrefab, _playerTransform.position, _playerTransform.rotation);
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
            
        }else 
        {
            Debug.Log("Seeds are depleted!");
        }
    }
}
