using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kayaengel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -1 * Time.deltaTime);
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
