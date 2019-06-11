using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_movement : MonoBehaviour
{
    Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            Vector3 posizione = new Vector3(Player.position.x, Player.position.y, transform.position.z);
            transform.position = posizione;
        }
    }
}
