using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpike : MonoBehaviour
{
    public GameObject ninja;
    public bool a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (a == true)
        {
            spikeTanah();
        }

    }

    public void spikeTanah()
    {
        GetComponent<PolygonCollider2D>().isTrigger = false;
        GetComponent<SpriteRenderer>().sortingOrder = 10;
    }

}
