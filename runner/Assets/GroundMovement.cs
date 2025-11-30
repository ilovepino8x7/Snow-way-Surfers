using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    [HideInInspector]
    public int moveSpeed = 30;
    private float timer;
    public bool collided = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3 (moveSpeed * Time.deltaTime, 0, 0);
        if (timer >= 5)
        {
            moveSpeed += moveSpeed / 10;
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
