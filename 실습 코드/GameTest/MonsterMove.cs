using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    Rigidbody2D rb;
    float moveX, moveY;
    [SerializeField] float speed = 7f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(moveX * speed, moveY * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "Coin+10":
                ScoreText.ScoreValue += 10;
                break;
            case "Coin+50":
                ScoreText.ScoreValue += 50;
                break;
            case "Coin-30":
                ScoreText.ScoreValue -= 30;
                break;
        }
    }
}
