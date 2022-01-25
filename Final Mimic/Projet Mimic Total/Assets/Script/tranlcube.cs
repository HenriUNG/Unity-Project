using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tranlcube : MonoBehaviour
{
    public float v;
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f,0.1f*v,0f);
    }

   
}
