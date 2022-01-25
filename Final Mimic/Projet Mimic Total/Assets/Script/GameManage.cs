using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] personnages;
    
    int index;
    void Start()
    {

        index = 0;
        personnages[index].SetActive(true);
        


    }


    // Update is called once per frame
    void Update()
    {

        Debug.Log(index); // envoie le debug en console
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            personnages[index].SetActive(false);
            index++;
            personnages[index].SetActive(true);


        }*/

        //Input 0
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            personnages[0].SetActive(true);
            personnages[1].SetActive(false);
            personnages[2].SetActive(false);
            personnages[3].SetActive(false);

        }

        //Input 1
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            personnages[0].SetActive(false);
            personnages[1].SetActive(true);
            personnages[2].SetActive(false);
            personnages[3].SetActive(false);

        }

        //Input 2
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            personnages[0].SetActive(false);
            personnages[1].SetActive(false);
            personnages[2].SetActive(true);
            personnages[3].SetActive(false);

        }

        //Input 3
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            personnages[0].SetActive(false);
            personnages[1].SetActive(false);
            personnages[2].SetActive(false);
            personnages[3].SetActive(true);

        }

       


    }
}
