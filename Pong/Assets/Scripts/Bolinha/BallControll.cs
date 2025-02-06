using UnityEngine;

public class BallControll : MonoBehaviour
{

    private Rigidbody2D _rigidbody2D;
    private AudioSource _audioSource;


    [SerializeField] private float speedBall;
    [SerializeField] private float directionCorrectX;
    [SerializeField] private float directionCorrectY;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
        BallMovement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void BallMovement()
    {
        _rigidbody2D.linearVelocity = new Vector2(speedBall, speedBall);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _audioSource.Play();
        _rigidbody2D.linearVelocity += new Vector2(directionCorrectX, directionCorrectY);
    }

}
