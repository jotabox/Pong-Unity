using UnityEngine;

public class BallControll : MonoBehaviour
{

    private Rigidbody2D _rigidbody2D;
    private AudioSource _audioSource;


    [SerializeField] private float speedBall;
    [SerializeField] private float directionCorrectX;
    [SerializeField] private float directionCorrectY;

    private Vector2 initialVelocity;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
        BallMovement();
    }

    public void BallMovement()
    {
        Vector2 newVelocity = new Vector2(speedBall, Random.Range(-1 * speedBall, 1 * speedBall));
        _rigidbody2D.linearVelocity = newVelocity;
        initialVelocity = newVelocity;


    }

    public void LeftBallMovement()
    {
        Vector2 newVelocity = new Vector2(-speedBall,Random.Range(-1 * speedBall , 1 * speedBall));
        _rigidbody2D.linearVelocity = newVelocity;
        initialVelocity = newVelocity;
    }


    public void ResetBall()
    {
        transform.position = Vector2.zero;
        BallMovement(); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _audioSource.Play();
        //_rigidbody2D.linearVelocity += new Vector2(directionCorrectX, directionCorrectY);

        Vector2 adjustedVelocity = _rigidbody2D.linearVelocity + new Vector2(directionCorrectX, directionCorrectY);

        if (adjustedVelocity.magnitude < initialVelocity.magnitude)
        {
            adjustedVelocity = adjustedVelocity.normalized * initialVelocity.magnitude;
        }

        _rigidbody2D.linearVelocity = adjustedVelocity;
    }

}
