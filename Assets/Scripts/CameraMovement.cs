using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(player.transform.localPosition.x + (player.transform.localScale.x * 15), 0, -10f);
        transform.localPosition = Vector3.Slerp(transform.localPosition, pos, 0.05f);
    }
}
