using UnityEngine;

public class BoardAI : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ball.GetComponent<BallAI>().StartBall();
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            float moveAmount = moveSpeed * Time.deltaTime;
            float x = transform.position.x;
            if (x + moveAmount > 6f)
            {
                moveAmount = 6f - x;
            }

            transform.Translate(moveAmount, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            float moveAmount = -moveSpeed * Time.deltaTime;
            float x = transform.position.x;
            if (x + moveAmount < -6f)
            {
                moveAmount = -6f - x;
            }

            transform.Translate(moveAmount, 0, 0);
        }
    }
}
