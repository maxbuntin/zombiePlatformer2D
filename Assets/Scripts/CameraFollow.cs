using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    
    private void Start()
    {
        float width = gameObject.GetComponent<Camera>().aspect * (gameObject.GetComponent<Camera>().orthographicSize * 2);

    }

    void Update()
    {
        if (player.transform.position.x >= transform.position.x) {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
