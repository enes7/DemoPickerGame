using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Kutu : MonoBehaviour
{
    public static Kutu instance;
    public Text toplanantxt;
    public int kuresayisi;
    
    public float mesafee;
    public Transform target;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    // Update is called once per frame
    void Update()
    {
        toplanantxt.text = "" + kuresayisi;

        mesafee = Vector3.Distance(transform.position, target.position);
        Debug.Log("" + mesafee);

        if (mesafee < 5)
        {
            Klon.instance.Durdur();
            
        }
        

    }


    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Kure")
        {
            kuresayisi++;
            Destroy(other.gameObject);
        }
        
        

    }

    




}
