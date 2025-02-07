using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]private int pointPlayer1;
    [SerializeField]private int pointPlayer2;


    public void AddPointPlayer1()
    {
        pointPlayer1++;
    }

    public void AddPointPlayer2()
    {
        pointPlayer2++;
    }
}
