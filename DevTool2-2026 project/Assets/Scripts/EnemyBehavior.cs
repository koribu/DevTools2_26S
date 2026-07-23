using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float speed = 2.0f;
    public Vector2 verticalBoundary;
    public Vector2 horizontalBoundary;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);

        if (verticalBoundary.y >= transform.position.y)
        {
            transform.position = new Vector3(Random.Range(horizontalBoundary.x, horizontalBoundary.y), verticalBoundary.x, transform.position.z);
        }
    }
}
