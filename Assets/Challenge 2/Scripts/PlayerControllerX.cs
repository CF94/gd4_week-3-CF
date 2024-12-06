using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private int timer = 0;
    public float resetDelay = 5;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {            
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);            
        }
    }
    void ResetValue()
    {
        int timer = 0;
        Debug.Log("Value reset to: " + timer);
    }
}
