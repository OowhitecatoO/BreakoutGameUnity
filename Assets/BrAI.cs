using UnityEngine;

public class BrAI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
        transform.parent.GetComponent<BrManager>().Check();
    }
}
