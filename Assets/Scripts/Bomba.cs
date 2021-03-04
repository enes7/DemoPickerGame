using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    public GameObject alev;
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
        if (other.gameObject.tag == "Normal")
        {
            Destroy(other.gameObject);
            Karakter.instance.hareket = false;
            alev.gameObject.SetActive(true);
        }
    }
}
