using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private UIManager _UIManager;

    private void Start()
    {
        _UIManager = GameObject.Find("UI Manager").GetComponent<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Animal"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal();
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            _UIManager.DecreaseLives();
            Destroy(gameObject);
        }
    }
}
