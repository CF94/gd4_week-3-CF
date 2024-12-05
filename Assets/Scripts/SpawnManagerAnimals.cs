using UnityEngine;

public class SpawnManagerAnimalsOptimized : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject[] animals;
    public float spawnRangeX = 16;
    public float spawnRangeZ = 10;
    private float spawnDelay = 2f;
    private float initialSpawnDelay = 1.5f;

    void Start()
    {
        InvokeRepeating("spawnRandomAnimals", initialSpawnDelay, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            //Vector3 randomSpawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, (spawnRangeZ));
            int randomIndex = Random.Range(0, animals.Length);
            Instantiate(animals[randomIndex], spawnPos, Quaternion.Euler(0, Random.Range(0, 360), 0));
            //Instantiate(animals[randomIndex], new Vector3(spawnRangeX, 0, spawnRangeZ), Quaternion.Euler(0, Random.Range(0, 360), 0));
        }

        if (Input.GetKey(KeyCode.C))
        {
            //Vector3 randomSpawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, (Random.Range(-spawnRangeZ, spawnRangeZ)));
            int randomIndex = Random.Range(0, animals.Length);
            Instantiate(animals[randomIndex], spawnPos, Quaternion.Euler(0, Random.Range(0, 360), 0));
            //Instantiate(animals[randomIndex], new Vector3(spawnRangeX, 0, spawnRangeZ), Quaternion.Euler(0, Random.Range(0, 360), 0));
        }
    }

    private void spawnRandomAnimals()
    {
        int randomIndex = Random.Range(0, animals.Length);

        Instantiate(animals[randomIndex], RandomSpawnPos(), Quaternion.Euler(0, Random.Range(0, 360), 0));
    }
    private Vector3 RandomSpawnPos()
    {
        Vector3 randomSpawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));

        return randomSpawnPos;
    }
}
