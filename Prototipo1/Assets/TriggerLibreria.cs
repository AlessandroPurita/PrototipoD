using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLibreria : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject libro;
    public GameObject pannello3;
    public GameObject testo3;
    bool l;
    void Start()
    {
        libro = GameObject.Find("libro");
        pannello3 = GameObject.Find("Panel3");
        pannello3.gameObject.SetActive(false);
        testo3 = GameObject.Find("Text3");
        testo3.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        l = libro.GetComponent<TriggerLibro>().l;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (l == true)
        {
            pannello3.gameObject.SetActive(true);
            testo3.gameObject.SetActive(true);

        }
        else
        {
            pannello3.gameObject.SetActive(false);
            testo3.gameObject.SetActive(false);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        pannello3.gameObject.SetActive(false);
        testo3.gameObject.SetActive(false);
        Destroy(GameObject.Find("porta").GetComponent<CircleCollider2D>());
        Destroy(GameObject.Find("block").GetComponent<CircleCollider2D>());

        //----
    }
}
