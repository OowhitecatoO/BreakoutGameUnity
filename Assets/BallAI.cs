using UnityEngine;

public class BallAI : MonoBehaviour
{
    [SerializeField] public int ballAmount = 5;

    private bool _running;

    public void StartBall()
    {
        if (_running) return;
        _running = true;

        Vector2 v = new Vector2(Random.Range(-1f, 1f), Random.Range(0.577f, 1f - 0.577f))
            .normalized * 6;
        GetComponent<Rigidbody2D>().velocity = v;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("out"))
        {
            Debug.Log("超出邊界");

            ballAmount--;

            if (ballAmount > 0)
            {
                transform.position = new Vector3(-0.13f, -3.97f, 0);
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                _running = false;

                Debug.Log($"還剩下 {ballAmount} 個球");
            }
            else
            {
                // TODO Game Over
                Time.timeScale = 0;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // StartBall();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
