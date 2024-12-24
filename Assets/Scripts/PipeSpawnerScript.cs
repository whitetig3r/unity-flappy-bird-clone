using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnWaitTime = 3, spawnTimer = 0;
    public float heightOffset = 5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"spawnTimer: {spawnTimer} and spawnWaitTime:{spawnWaitTime}");
        if (spawnTimer < spawnWaitTime)
        {
            spawnTimer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            spawnTimer = 0;
        }
    }

    private void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
