using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Mensaje : MonoBehaviour

{
    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void escribirconsola()
    {
        if (num1 == num2)
        {
            Debug.Log("Error");
        }
        else if (num1 > num2)
        {
            while (num1 >= num2)
            {
                Debug.Log(num1);
                num1--;
            }
        }
        else
        {
            Debug.Log("Error");
        }

    }

    
        
}
