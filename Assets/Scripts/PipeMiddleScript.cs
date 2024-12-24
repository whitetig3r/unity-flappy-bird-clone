using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicManagerScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && !logic.isGameOver)
        {
            logic.AddScore();
        }
    }
}
