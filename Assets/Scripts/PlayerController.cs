using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput, verticalInput, speed = 10f, moveLimitX = 10f, moveLimitZUp = 14f, moveLimitZDown = 0f;

    public GameObject projectalePrefab;

    private Vector3 moveDirection, projectalePosition;

    void Update()
    {
        //Move player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        moveDirection = (Vector3.right * horizontalInput) + (Vector3.forward * verticalInput);
        transform.Translate(moveDirection * speed * Time.deltaTime);

        //Set limits for horizontal movement        
        if(transform.position.x < -moveLimitX)
        {
            transform.position = new Vector3(-moveLimitX, transform.position.y, transform.position.z);
        } 
        else if(transform.position.x > moveLimitX)
        {
            transform.position = new Vector3(moveLimitX, transform.position.y, transform.position.z);
        }

        //Set limits for vertical movement  
        if (transform.position.z < moveLimitZDown)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, moveLimitZDown);
        }
        else if (transform.position.z > moveLimitZUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, moveLimitZUp);
        }

        //Create a projectile when the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            projectalePosition = transform.position + new Vector3(0f, 0f, 1f);
            Instantiate(projectalePrefab, projectalePosition, projectalePrefab.transform.rotation);
        }
    }
}
