using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    public float speed = 1.0f;
    public InputActionAsset playerController;

    private InputAction moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World from Start Func");

        moveInput = playerController.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Move input is: " + moveInput.ReadValue<Vector2>());

        float horizontalInput = moveInput.ReadValue<Vector2>().x; // -1 , 0 or 1 value for horizontal movement
        float verticalInput = moveInput.ReadValue<Vector2>().y; // -1 , 0 or 1 value for vertical movement

        transform.position = new Vector3(transform.position.x + horizontalInput * speed * Time.deltaTime, 
                                        transform.position.y + verticalInput * speed * Time.deltaTime, 
                                        transform.position.z);
    }
}
