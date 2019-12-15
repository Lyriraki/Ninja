using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMelayang : MonoBehaviour
{
    public GameObject ninja;
    public bool a;
    private int nilai ; 

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    // Update is called once per frame
    public void Update()
    {
        if (a == true)
        {   
            melayang();
        }
    }

    public void melayang()
    {
        GetComponent<BoxCollider2D>().isTrigger = false;
        transform.position = new Vector3(transform.position.x - 0.28f + Time.deltaTime, transform.position.y, transform.position.z);
        GetComponent<SpriteRenderer>().sortingOrder = 10;
    }
}

