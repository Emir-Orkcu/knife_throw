using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kucukcember : MonoBehaviour
{
    public float hiz;
    Rigidbody2D fizik;
    bool haraketkontrol = false;
    GameObject OyunYonetimi;
    
   


    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        OyunYonetimi = GameObject.FindGameObjectWithTag("oyunyonetımıtag");

    }

    
    void FixedUpdate()
    {
        if (!haraketkontrol)
        {
     fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "donencembertag")
        {
            transform.SetParent(col.transform);
            haraketkontrol = true;
            
        }
        if (col.tag == "daggertag")
        {
            OyunYonetimi.GetComponent<oyunyonetim>().OyunBitti();
        }
        
    }

   


}
