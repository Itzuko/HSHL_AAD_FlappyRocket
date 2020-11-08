using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public float gravity;
    private Rigidbody2D rb;
    private Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        gravity = rb.gravityScale;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 veloctiy = rb.velocity;
        float angle = Mathf.Atan2(veloctiy.y, 5) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));

        if(Input.GetKey(KeyCode.Space) || Input.touchCount > 0)
        {
            rb.AddForce(Vector2.up * gravity * 2.5f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name != "rocket_player")
        {
            SceneManager.LoadScene("StartScene");
            scoreCounterManager.score = 0;
        }
    }
}
