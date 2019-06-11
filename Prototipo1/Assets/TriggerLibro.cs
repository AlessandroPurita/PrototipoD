using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLibro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pannello2;
    public GameObject testo2;
    public GameObject trig;
    bool t;
    public bool l=false;
    void Start()
    {
        pannello2 = GameObject.Find("Panel2");
        pannello2.gameObject.SetActive(false);
        testo2 = GameObject.Find("Text2");
       testo2.gameObject.SetActive(false);
        trig = GameObject.Find("Trig");
       
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        t = trig.GetComponent<TriggerPorta>().trigger;
        if (t == true)
        {
            pannello2.gameObject.SetActive(true);
            testo2.gameObject.SetActive(true);

        }
        else
        {
            pannello2.gameObject.SetActive(false);
            testo2.gameObject.SetActive(false);
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        pannello2.gameObject.SetActive(false);
        testo2.gameObject.SetActive(false);
        l = true;
        //----
    }
}
