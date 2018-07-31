using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour
{

    public float timeSinceLastTrigger = 0f;
    private bool foundClearArea = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastTrigger += Time.deltaTime;
        if (timeSinceLastTrigger > 2f && Time.realtimeSinceStartup > 10f && !foundClearArea)
        {
            foundClearArea = true;
            SendMessageUpwards("OnFindClearArea");         
        }
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.tag != "Player")
        {
            timeSinceLastTrigger = 0f;
        }
    }
}