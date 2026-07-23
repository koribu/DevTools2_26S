using UnityEngine;

public class BGBehavior : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector2 boundary;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);

        if(boundary.y >= transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, boundary.x, transform.position.z);
        }
    }
}
