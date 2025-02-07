using UnityEngine;

public class GoalControll : MonoBehaviour
{

    private GameManager _gameManager;
    private BallControll _ballControll;
    [SerializeField] private bool isLeftGoal;

    private void Start()
    {
        _gameManager = FindAnyObjectByType<GameManager>();
        _ballControll = FindAnyObjectByType<BallControll>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Ball"))
        {
            _ballControll.ResetBall();


            if (isLeftGoal)
            {
                _gameManager.AddPointPlayer2();
            }
            else
            {
                _gameManager.AddPointPlayer1();
                _ballControll.LeftBallMovement();
            }
        }
    }
}
