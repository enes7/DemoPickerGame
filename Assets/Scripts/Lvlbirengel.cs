using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvlbirengel : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Kure")
        {
            Destroy(other.gameObject);
            
        }
        if (other.gameObject.tag == "Normal")
        {
            Destroy(this.gameObject);

        }
    }

    
}
