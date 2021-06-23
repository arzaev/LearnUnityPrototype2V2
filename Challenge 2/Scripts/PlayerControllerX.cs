using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private GameObject currentDogPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (dogPrefab != null
            && currentDogPrefab == null
            && Input.GetKeyDown(KeyCode.Space))
        {
            currentDogPrefab = Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
