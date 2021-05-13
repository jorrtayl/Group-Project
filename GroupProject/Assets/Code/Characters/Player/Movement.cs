using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = .03f;

    }

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirection * speed;
    }
}
