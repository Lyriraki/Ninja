using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpikeJatuh : MonoBehaviour
{
    public GameObject ninja;
    public bool a;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sortingOrder = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (a == true)
        {
            jatuh();
        }
    }

    public void jatuh()
    {
        GetComponent<BoxCollider2D>().isTrigger = false;
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.38f + Time.deltaTime, transform.position.z);
        GetComponent<SpriteRenderer>().sortingOrder = 10;
    }
}
