using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Ball : MonoBehaviour
{
    [SerializeField] private Vector3 _velocity;
    [SerializeField] private float _speed;
    [SerializeField] private LayerMask _layerMask;
    public int Score = 0;
    public static int HighScore = 0;
    private Vector3 _oldPosition;
    public GameObject Spawn;
    public Renderer Renderer;
    

    private void Start()
    {
        float randomSize = Random.Range(1.5f, 2.5f);
        transform.localScale = new Vector3(randomSize, randomSize, randomSize);
        _velocity = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
        _speed = Random.Range(10f, 20f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Score++;
            if (Score > HighScore)
            {
                HighScore = Score;
            }
        }
    }

    private void Update()
    {
        Score.ToString();
        transform.position += _velocity * _speed * Time.deltaTime;

        Vector3 toNewPosition = transform.position - _oldPosition;

        Ray Ray = new Ray(_oldPosition, _velocity);
        if (Physics.Raycast(Ray, out RaycastHit hit, toNewPosition.magnitude, _layerMask))
        {
            Vector3 newDirection = Vector3.Reflect(_velocity, hit.normal);
            _velocity = newDirection;
        }

        _oldPosition = transform.position;


        if (transform.position.x < -25)
        {
            RestartsScene();
        }

        if (transform.position.x > 25)
        {
            RestartsScene();
        }
    }

    public void setMatireal(Material material)
    {
        Renderer.material = material;
    }

    private void RestartsScene()
    {
        Score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
    