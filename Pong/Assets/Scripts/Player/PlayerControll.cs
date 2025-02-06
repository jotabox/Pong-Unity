using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed;
    [SerializeField]
    private bool isPlayer1;
    [SerializeField]
    private float minY;
    [SerializeField]
    private float maxY;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    private void MovePlayer()
    {

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, minY, maxY));

        if (isPlayer1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector2.up * playerSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector2.down * playerSpeed * Time.deltaTime);
            }
        }
        else
        {
            if(Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector2.up * playerSpeed * Time.deltaTime);
            }

            if(Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector2.down * playerSpeed * Time.deltaTime);
            }

        }

    }
}

