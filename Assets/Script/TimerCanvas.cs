using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCanvas : MonoBehaviour
{
    private float currTime;
    [SerializeField] private Text timerText = null;

    // Start is called before the first frame update
    private void Start()
    {
        float maxTime = 30.0f;
        currTime = maxTime;
    }

    // Update is called once per frame
    private void Update()
    {
        if (currTime < 0)
            return;
        timerText.text=((int)currTime).ToString();
        currTime -= Time.deltaTime;
    }
}