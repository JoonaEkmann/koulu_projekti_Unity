using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    public GameObject playerShip;

    private float height = 4.0f;
    private float distance = 5.0f;

    void Start() {
        transform.position = playerShip.transform.TransformPoint(0f, height, -distance);
    }
    
    void Update() {
        transform.position = playerShip.transform.TransformPoint(0f, height, -distance);
        transform.rotation = playerShip.transform.rotation;
    }
}