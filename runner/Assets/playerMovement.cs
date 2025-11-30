using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    private int lane = 1;
    public GameObject land;
    public List<GameObject> landList;
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
            transform.position = new Vector3(-90, 1, 7);
        }
        else
        {
            transform.position = new Vector3(-90, 1, -7);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "land" && other.transform.parent.GetComponent<GroundMovement>().collided == false)
        {
            other.transform.parent.GetComponent<GroundMovement>().collided = true;
            GameObject Newlands = Instantiate(land, new Vector3(transform.position.x + 80, 0, 0), Quaternion.identity);
            landList.Add(Newlands);
            if (landList.Count >= 3)
            {
                Destroy(landList[0]);
                landList.RemoveAt(0);
            }
        }
        else if (other.tag == "enemy")
        {
            EndGame();
        }
    }
    public void EndGame()
    {
        SceneManager.LoadScene("Start");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
