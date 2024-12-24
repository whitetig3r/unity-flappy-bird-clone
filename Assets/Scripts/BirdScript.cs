using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public LogicManagerScript logicManager;
    public float upwardFlapStrength;
    public bool isAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            rigidBody.linearVelocity = Vector2.up * upwardFlapStrength;
        }

        if (transform.position.y > 15 || transform.position.y < -15)
        {
            logicManager.TriggerGameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        logicManager.TriggerGameOver();
    }
}
