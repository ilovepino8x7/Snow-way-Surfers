using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private int lane = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && lane < 2)
        {
            lane++;
        }
        else if (Input.GetKeyDown(KeyCode.A) && lane > 0)
        {
            lane--;
        }

        if (lane == 1)
        {
            transform.position = new Vector3(-90, 1, 0);
        }
        else if (lane == 0)
        {
            transform.position = new Vector3(-90, 1 , 7);
        }
        else
        {
            transform.position = new Vector3(-90 ,1 , -7);
        }
    }
}
