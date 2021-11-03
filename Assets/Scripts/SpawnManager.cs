using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private Vector3 spawnPositionHorizontal, spawnPositionVertical;
    private float spawnLimitX = 10f, spawnLititZUp = 14f, spawnLimitZDown = 0f, spawnPosX = -20f, spawnPosZ = 20f, startDelay = 2f, spawnInterval = 1.5f;
    private int animalIndex;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimalHorizontal), startDelay, spawnInterval);
        InvokeRepeating(nameof(SpawnRandomAnimalVertical), startDelay, spawnInterval);
    }

    private void SpawnRandomAnimalHorizontal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnPositionHorizontal = new Vector3(Random.Range(-spawnLimitX, spawnLimitX), 0f, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPositionHorizontal, animalPrefabs[animalIndex].transform.rotation);
    }

    private void SpawnRandomAnimalVertical()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnPositionVertical = new Vector3(spawnPosX, 0f, Random.Range(spawnLimitZDown, spawnLititZUp));
        Instantiate(animalPrefabs[animalIndex], spawnPositionVertical, Quaternion.AngleAxis(90f, Vector3.up));
    }
}
