using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusikManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    private MusikManager instance = null ;
    

    public MusikManager Instance()
    {
        return instance ; 
    }

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this ;
        }
        
        DontDestroyOnLoad(this.gameObject);
    }

    

}
