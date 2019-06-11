using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPorta : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pannello;
    public GameObject testo;
    void Start()
    {
        pannello = GameObject.Find("Panel");
        pannello.gameObject.SetActive(false);
        testo = GameObject.Find("Text");
        testo.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        pannello.gameObject.SetActive(true);
        testo.gameObject.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        pannello.gameObject.SetActive(false);
        testo.gameObject.SetActive(false);
    }
}
