using UnityEngine;

public class BrManager : MonoBehaviour
{
    // [SerializeField] private GameObject[] brPrefabs;
    [SerializeField] private GameObject brPrefab;
    [SerializeField] private float brXOffset = 3.2f;
    [SerializeField] private float brYOffset = -1.3f;

    int Remain()
    {
        return 1;
    }

    void SpawnBr()
    {
        for (int yOffset = 0; yOffset < 3; yOffset++)
        {
            for (int xOffset = 0; xOffset < 5; ++xOffset)
            {
                GameObject br = Instantiate(brPrefab, transform);
                float x = -6.7f + brXOffset * xOffset;
                float y = 3.7f + brYOffset * yOffset;
                br.transform.position = new Vector3(x, y, 0);
            }
        }
    }

    public void Check()
    {
        int remain = transform.childCount - 1;
        if (remain == 0)
        {
            // TODO Game Over
            Time.timeScale = 0;
        }

        Debug.Log($"還剩下 {remain} 個方塊");
    }

    // Start is called before the first frame update
    void Start()
    {
        SpawnBr();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
