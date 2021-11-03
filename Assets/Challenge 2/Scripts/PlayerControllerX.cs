using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timePassed, timeToReach = 1f;

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timePassed >= timeToReach)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timePassed = 0f;
        }
    }
}
