using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float moveSpeed = 8f; // [SerializeField] makes the variable visible in the Unity editor
    [SerializeField] float jumpSpeed = 10f;
    
    bool pressedJump = false;
    Collider coll;
    Rigidbody rb;
    
    

    
    void Start()
    {
        PrintInstruction();
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();

        // Example of a for loop: Countdown timer
        for (int i = 5; i > 0; i--)
        {
            Debug.Log("Game starts in " + i + " seconds");
        }
        Debug.Log("Go!");

    }

    void Update()
    
    {
        walkHandler();
        jumpHandler();

        // Example of a while loop: Simple condition check
        int counter = 0;
        while (counter < 10)
        {
            Debug.Log("Counter is at: " + counter);
            counter++;
        }

    }
    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Hit the object to change colour!");
    }
    void walkHandler()
    {
    float hAxis = Input.GetAxis("Horizontal");
    float vAxis = Input.GetAxis("Vertical");
    Vector3 movement = new Vector3(hAxis, 0, vAxis) * moveSpeed * Time.deltaTime;
    transform.Translate(movement);
        // Current position
    Vector3 currPosition = transform.position;
        // New position
    Vector3 newPosition = currPosition + movement;
        // Move the rigid body
    rb.MovePosition(newPosition);
    }
    void jumpHandler()
    {
        float jAxis = Input.GetAxis("Jump");
        // Check if the player is pressing the jump key
        if (jAxis > 0f)
        {
            // Make sure we've not already jumped on this key press
            if (!pressedJump)
            {
                // We are jumping on the current key press
                pressedJump = true;
                // Jumping vector
                Vector3 jumpVector = new Vector3(0f, jumpSpeed, 0f);
                // Make the player jump by adding velocity
                rb.velocity = rb.velocity + jumpVector;
            }
        }
        else
        {
            // Update flag so it can jump again if we press the jump key
            pressedJump = false;
        }
    }
    // Check if the object is grounded
    bool CheckGrounded()
    {
        // Object size in x
        float sizeX = coll.bounds.size.x;
        float sizeZ = coll.bounds.size.z;
        float sizeY = coll.bounds.size.y;
        // Position of the 4 bottom corners of the game object
        // We add 0.01 in Y so that there is some distance between the point and the floor
        Vector3 corner1 = transform.position + new Vector3(sizeX / 2, -sizeY / 2 + 0.01f, sizeZ / 2);
        Vector3 corner2 = transform.position + new Vector3(-sizeX / 2, -sizeY / 2 + 0.01f, sizeZ / 2);
        Vector3 corner3 = transform.position + new Vector3(sizeX / 2, -sizeY / 2 + 0.01f, -sizeZ / 2);
        Vector3 corner4 = transform.position + new Vector3(-sizeX / 2, -sizeY / 2 + 0.01f, -sizeZ / 2);
        // Send a short ray down the cube on all 4 corners to detect ground
        bool grounded1 = Physics.Raycast(corner1, new Vector3(0, -1, 0), 0.01f);
        bool grounded2 = Physics.Raycast(corner2, new Vector3(0, -1, 0), 0.01f);
        bool grounded3 = Physics.Raycast(corner3, new Vector3(0, -1, 0), 0.01f);
        bool grounded4 = Physics.Raycast(corner4, new Vector3(0, -1, 0), 0.01f);
        // If any corner is grounded, the object is grounded
        return (grounded1 || grounded2 || grounded3 || grounded4);
    }
    void OnTriggerEnter(Collider collider)
    {
        //// Check if we ran into a coin
        //if (collider.gameObject.tag == "Coin")
        //{
        //    print("Grabbing coin..");

        //    // Destroy coin
        //    Destroy(collider.gameObject);
        //}
        if (collider.gameObject.tag == "Enemy")
        {
            // Game over
            print("game over");

    // Soon.. go to the game over scene
}
    }
}


    

    

