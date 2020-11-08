using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeController : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-moveSpeed, 0);
        if(this.transform.position.x < -15f)
        {
            Destroy(this.gameObject);
        }
    }
}
