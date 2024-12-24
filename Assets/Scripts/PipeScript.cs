using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
            return;
        }

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
