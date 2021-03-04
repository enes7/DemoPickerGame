using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Karakter : MonoBehaviour
{
    public static Karakter instance;
    public bool sag, sol, hareket = false,devam=false,devam2=false,hiz,lvl2bool,lvl3bool,lvl4bool,lvl5bool,lvl6bool,lvl7bool,lvl8bool,lvl9bool,lvl10bool;
    public GameObject baslangicpanel,zemin1,zemin2,kutu2,tamam,tamam1,buton,resbut;
    public bool lvl2boolres, lvl3boolres, lvl4boolres, lvl5boolres, lvl6boolres, lvl7boolres, lvl8boolres, lvl9boolres, lvl10boolres;
    public int bslangicsayi=10;
    public Text olmasigerekentxt;
    RaycastHit hit1;
    public GameObject kutu1,kuton;

    
    
   

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

    void Update()
    {
        


        KutuOnu();
        olmasigerekentxt.text = "" + bslangicsayi;
        
        if (hareket == true)
        {
            Swerwe();
            
        }






        if (Kutu.instance.kuresayisi >= bslangicsayi)
        {
            zemin1.gameObject.SetActive(true);
            kutu1.gameObject.SetActive(false);
            tamam.gameObject.SetActive(true);
            

            hareket = true;

            devam = true;

            Klon.instance.calis = true;

            if (Kutuu.instance.kuresayisi >= bslangicsayi)
            {
                zemin2.gameObject.SetActive(true);
                kutu2.gameObject.SetActive(false);
                tamam1.gameObject.SetActive(true);
                hareket = true;
                devam2 = true;
                

                Klon.instance.calis = true;
            }
            else
            {
                resbut.gameObject.SetActive(true);
            }

        }
        else
        {
            resbut.gameObject.SetActive(true);
        }

        



    }
    

    public void Swerwe()
    {

        Vector3 saggit = new Vector3(0.771f, transform.position.y, transform.position.z);
        Vector3 solgit = new Vector3(-0.771f, transform.position.y, transform.position.z);
        if (hiz == true)
        {
            transform.Translate(0, 0, 2f * Time.deltaTime);
        }
       
        else
        {
            transform.Translate(0, 0, 1.5f * Time.deltaTime);
        }
        



        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = Vector3.Lerp(transform.position, solgit, 20 * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = Vector3.Lerp(transform.position, saggit, 20 * Time.deltaTime);
        }
        if (Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0);
            if (parmak.deltaPosition.x > 0)
            {
                sag = true;
                sol = false;
            }

            if (parmak.deltaPosition.x < 0)
            {
                sag = false;
                sol = true;
            }

            if (sag == true)
            {
                transform.position = Vector3.Lerp(transform.position, saggit, 2 * Time.deltaTime);
            }
            else if (sol == true)
            {
                transform.position = Vector3.Lerp(transform.position, solgit, 2 * Time.deltaTime);
            }
        }
    }

    public void Basla()
    {
        hareket = true;
        baslangicpanel.gameObject.SetActive(false);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bayrak")
        {
            devam = false;

        }

        
    }

    private void OnCollisionEnter(Collision other)
    {


        Debug.Log("");
        if (other.gameObject.tag == "lvl2")
        {
            buton.gameObject.SetActive(true);
            lvl2bool = true;
            
            //SceneManager.LoadScene("Level2");
        }
        if (other.gameObject.tag == "lvl3")
        {
            buton.gameObject.SetActive(true);
            lvl3bool = true;
            
            //SceneManager.LoadScene("Level2");
        }
        if (other.gameObject.tag == "lvl4")
        {
            buton.gameObject.SetActive(true);
            lvl4bool = true;
            
            //SceneManager.LoadScene("Level2");
        }
        if (other.gameObject.tag == "lvl5")
        {
            buton.gameObject.SetActive(true);
            lvl5bool = true;
            
            hiz = true;
            //SceneManager.LoadScene("Level2");
        }
        if (other.gameObject.tag == "lvl6")
        {
            buton.gameObject.SetActive(true);
            lvl6bool = true;
            
            hiz = true;
            //SceneManager.LoadScene("Level2");
        }
        if (other.gameObject.tag == "lvl7")
        {
            buton.gameObject.SetActive(true);
            lvl7bool = true;
            
            hiz = true;
            //SceneManager.LoadScene("Level2");
        }
        if (other.gameObject.tag == "lvl8")
        {
            buton.gameObject.SetActive(true);
            lvl8bool = true;
            
            hiz = true;
            //SceneManager.LoadScene("Level2");
        }
        if (other.gameObject.tag == "lvl9")
        {
            buton.gameObject.SetActive(true);
            lvl9bool = true;
            
            hiz = true;
            //SceneManager.LoadScene("Level2");
        }
        if (other.gameObject.tag == "lvl10")
        {
            buton.gameObject.SetActive(true);
            lvl10bool = true;
            
            hiz = true;
            //SceneManager.LoadScene("Level2");
        }
        if (other.gameObject.tag == "bitis")
        {
            hareket = false;
        }

        

        if (other.gameObject.tag == "Kutu")
        {

            //kutu1.transform.position = new Vector3(kutu1.transform.position.x, kutu1.transform.position.y, kutu1.transform.position.z + 10f);

            //Invoke("KutuOnu", 10.0f);
            Destroy(other.gameObject);

        }


    }
    public void Sahneler()
    {
        if (lvl2bool == true)
        {
            SceneManager.LoadScene("Level2");
            lvl2bool = false;
        }
        if (lvl3bool == true)
        {
            SceneManager.LoadScene("Level3");
            lvl3bool = false;
            
        }
        if (lvl4bool == true)
        {
            SceneManager.LoadScene("Level4");
            lvl4bool = false;
            
        }
        if (lvl5bool == true)
        {
            SceneManager.LoadScene("Level5");
            lvl5bool = false;
            
        }
        if (lvl6bool == true)
        {
            SceneManager.LoadScene("Level6");
            lvl6bool = false;

        }
        if (lvl7bool == true)
        {
            SceneManager.LoadScene("Level7");
            lvl7bool = false;

        }
        if (lvl8bool == true)
        {
            SceneManager.LoadScene("Level8");
            lvl8bool = false;

        }
        if (lvl9bool == true)
        {
            SceneManager.LoadScene("Level9");
            lvl9bool = false;

        }
        if (lvl10bool == true)
        {
            SceneManager.LoadScene("Level10");
            lvl10bool = false;

        }
    }

    public void Tekrarbasla()
    {
        if (lvl2boolres == true)
        {
            SceneManager.LoadScene("Level2");
            lvl2boolres = false;

        }
        if (lvl3boolres == true)
        {
            SceneManager.LoadScene("Level3");
            lvl3boolres = false;

        }
        if (lvl4boolres == true)
        {
            SceneManager.LoadScene("Level4");
            lvl4boolres = false;

        }
        if (lvl5boolres == true)
        {
            SceneManager.LoadScene("Level5");
            lvl5boolres = false;

        }
        if (lvl6boolres == true)
        {
            SceneManager.LoadScene("Level6");
            lvl6boolres = false;

        }
        if (lvl7boolres == true)
        {
            SceneManager.LoadScene("Level7");
            lvl7boolres = false;

        }
        if (lvl8boolres == true)
        {
            SceneManager.LoadScene("Level8");
            lvl8boolres = false;

        }
        if (lvl9boolres == true)
        {
            SceneManager.LoadScene("Level9");
            lvl9boolres = false;

        }
        if (lvl10boolres == true)
        {
            SceneManager.LoadScene("Level10");
            lvl10boolres = false;

        }
    }

    public void KutuOnu()
    {

        /*if (Physics.Raycast(transform.position, transform.forward, out hit1, 3))
        {

            if (hit1.collider.gameObject.tag == "Kutu2")
            {

                hareket = false;
                Klon.instance.Durdur();
                Debug.Log("gfgjfghj");
            }

            /*else
            {
                Klon.instance.calis = true;
            }
        }*/

        if (Kutu.instance.mesafee <= 3)
        {

            
            if (devam == false)
            {
                
                hareket = false;
                
            }
            
        }
        if (Kutuu.instance.mesafee <= 3)
        {
            if (devam2 == false)
            {
                hareket = false;
                
            }
            

        }


    }








}
