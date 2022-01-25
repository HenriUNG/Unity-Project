using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class XBOTSCRIPT : MonoBehaviour
{
   
    public Text text;
    public Text text2;
    public Text count;
    public GameObject cube;



    // Start is called before the first frame update
    void Start()
    {
        
        text.enabled = false;
        text2.enabled = true;
        cube.SetActive(true);
        count.enabled = true; ;


}

    

    // Update is called once per frame
    void Update()
    {

      if (  Between (cube.transform.position.y,5,10) == true  )
        {
            text.enabled = true;
            text2.enabled = false;



        }
        else
        {
            text.enabled = false;
            text2.enabled = true;
        }


        //float pourcent =  
      
        
    }

    private float precision (float cible)
    {

        return 0;
    }
    private bool Between(float pos, float min, float max)

    {
        if (pos < min || pos > max)
        {
            return false;
        }
        else { return true; }
    }
}

