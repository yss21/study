using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugObject : MonoBehaviour
{
    float currTime;

    private int Add(int a, int b)
    {
        return a + b;
    }

    private void Awake()
    {

    }

    // Start is called before the first frame update
    private void Start()
    {
        float maxTime = 3.0f;
        currTime = maxTime;
    }

    // Update is called once per frame
    private void Update()
    {
        if (currTime >= 0)
        {
            Debug.Log((int)currTime);
            currTime -= Time.deltaTime;
        }
    }
}