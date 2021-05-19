using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dondurme : MonoBehaviour
{

    public float hız;
    
   
    void Update()
    {
        transform.Rotate(0, 0, hız*Time.deltaTime);
    }
}
