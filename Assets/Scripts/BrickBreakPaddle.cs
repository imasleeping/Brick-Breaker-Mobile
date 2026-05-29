using UnityEngine;

public class BrickBreakPaddle : MonoBehaviour
{
    public GameObject Paddle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Paddle.transform.position.x > Screen.width)
        {

        }
    }
}
