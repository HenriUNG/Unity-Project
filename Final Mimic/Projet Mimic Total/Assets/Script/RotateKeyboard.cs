using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateKeyboard : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20.0f;

    // Update is called once per frame
    void Update()
    {
        

        //Rotate droite
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().Rotate(new Vector3(0.0f, 3.0f, 0.0f) * Time.deltaTime * speed, Space.World);
        }

        //Rotate gauche

        if (Input.GetKey(KeyCode.Q))
        {
            GetComponent<Transform>().Rotate(new Vector3(0.0f, -3.0f, 0.0f) * Time.deltaTime * speed, Space.World);
        }
        

    }
}
