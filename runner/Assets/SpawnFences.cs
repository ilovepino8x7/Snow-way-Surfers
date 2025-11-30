using UnityEngine;

public class SpawnFences : MonoBehaviour
{
    private float timer;
    public GameObject fence;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 3)
        {
            timer = 0;
            SpawnFence();
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
    private void SpawnFence()
    {
        int lane = Random.Range(0,3);
        if (lane == 0)
        {
            Instantiate(fence, new Vector3(transform.position.x + 40, 0, 7), Quaternion.identity);
        }
        else if (lane == 1)
        {
            Instantiate(fence, new Vector3(transform.position.x + 40, 0, 1.7f), Quaternion.identity);
        }
        else
        {
            Instantiate(fence, new Vector3(transform.position.x + 40, 0, -5), Quaternion.identity);
        }
    }
}
