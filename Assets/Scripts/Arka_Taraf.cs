using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arka_Taraf : MonoBehaviour
{
    // Start is called before the first frame update
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

        if (other.gameObject.tag == "engel")
        {

            Destroy(other.gameObject);
        }

    }


}
