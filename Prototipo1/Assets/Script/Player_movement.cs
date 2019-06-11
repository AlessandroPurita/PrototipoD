using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 3f;
    Rigidbody2D player;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector2 velocity = new Vector2(moveSpeed * h, moveSpeed * v);
        player.velocity = velocity;


        anim.SetInteger("verticale", (int)v);
        anim.SetInteger("orizzontale", (int)h);

    }
}
