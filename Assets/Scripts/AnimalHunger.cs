using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    [SerializeField] private Slider hungerSlider;
    [SerializeField] private int amountToFeed;

    private int currentFedAmout = 0;
    private UIManager _UIManager;

    private void Start()
    {
        _UIManager = GameObject.Find("UI Manager").GetComponent<UIManager>();
        hungerSlider.value = 0;
        hungerSlider.maxValue = amountToFeed;
        hungerSlider.fillRect.gameObject.SetActive(false);
    }

    public void FeedAnimal()
    {
        currentFedAmout++;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmout;

        if (currentFedAmout == amountToFeed)
        {
            _UIManager.IncreaseScore(amountToFeed);
            Destroy(gameObject);
        }
    }
}
