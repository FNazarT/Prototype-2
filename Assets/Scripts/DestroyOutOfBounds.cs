using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float rightBound = 30f, topBound = 30f, lowerBound = -10f;

    private UIManager _UIManager;

    private void Start()
    {
        _UIManager = GameObject.Find("UI Manager").GetComponent<UIManager>();
    }

    void Update()
    {
        if(transform.position.x > rightBound)       //Destroy animal moving horizontally when it's moved out of screen
        {
            _UIManager.DecreaseLives();
            Destroy(gameObject);
        }
        else if(transform.position.z > topBound)        //Destroy food when it's moved out of screen
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)      //Destroy animal moving vertically when it's moved out of screen
        {
            _UIManager.DecreaseLives();
            Destroy(gameObject);
        }
    }
}
