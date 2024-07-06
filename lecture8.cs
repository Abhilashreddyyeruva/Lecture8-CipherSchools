using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(add(2, 4)); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int add(int num1,int num2)
    {
        int result = num1 + num2;

        return result;
    }
}
