using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klon : MonoBehaviour
{
    public static Klon instance;

    public float sagkisim = 1.624f;
    public float solkisim = -1.154f;
    public float ortakisim = -0.88f;
    public GameObject odul,lvlbirengel,upengel,bomba;
    public Transform karakter;
    public bool calis;
    void Start()
    {
        calis = true;
        InvokeRepeating("Klonla", 0, 0.2f);
        InvokeRepeating("Klonla1", 0, 7f);
        InvokeRepeating("Klonla2", 0, 5f);
        InvokeRepeating("Klonla3", 0, 8f);
        if (Karakter.instance.hareket == true)
        {
            
            
        }

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
        

    }
    public void Klonla()
    {
        if (calis == true)
        {
            int sayi = Random.Range(0, 100);

            if (sayi > 0 && sayi < 100)
            {
                Olustur(odul, 0.3f);
            }
        }
        
    }

    public void Klonla1()
    {
        if (calis == true)
        {
            int sayi = Random.Range(0, 100);

            if (sayi > 0 && sayi < 100)
            {
                Olustur1(lvlbirengel, 0.3f);
            }
        }

    }
    public void Klonla2()
    {
        if (calis == true)
        {
            int sayi = Random.Range(0, 100);

            if (sayi > 0 && sayi < 100)
            {
                Olustur1(upengel, 0.3f);
            }
        }

    }
    public void Klonla3()
    {
        if (calis == true)
        {
            int sayi = Random.Range(0, 100);

            if (sayi > 0 && sayi < 100)
            {
                Olustur1(bomba, 0.3f);
            }
        }

    }
    public void Durdur()
    {
        calis = false;
    }

    public void Olustur(GameObject nesne, float ust)

    {

        GameObject yeniklon = Instantiate(nesne);
        int sayi = Random.Range(0, 100);

        if (sayi < 70)
        {
            yeniklon.transform.position = new Vector3(sagkisim, karakter.transform.position.y, karakter.position.z + 2);


        }
        if (sayi > 70)
        {
            yeniklon.transform.position = new Vector3(solkisim, karakter.transform.position.y , karakter.position.z + 2);
        }
        if (sayi < 30)
        {
            yeniklon.transform.position = new Vector3(ortakisim, karakter.transform.position.y, karakter.position.z + 2);
        }
    }
    public void Olustur1(GameObject nesne, float ust)

    {

        GameObject yeniklon = Instantiate(nesne);
        int sayi = Random.Range(0, 100);

        if (sayi < 70)
        {
            yeniklon.transform.position = new Vector3(sagkisim, karakter.transform.position.y, karakter.position.z + 6);


        }
        if (sayi > 70)
        {
            yeniklon.transform.position = new Vector3(solkisim, karakter.transform.position.y, karakter.position.z + 6);
        }
        if (sayi < 30)
        {
            yeniklon.transform.position = new Vector3(ortakisim, karakter.transform.position.y, karakter.position.z + 6);
        }
    }
    public void Olustur2(GameObject nesne, float ust)

    {

        GameObject yeniklon = Instantiate(nesne);
        int sayi = Random.Range(0, 100);

        if (sayi < 70)
        {
            yeniklon.transform.position = new Vector3(sagkisim, karakter.transform.position.y, karakter.position.z + 6);


        }
        if (sayi > 70)
        {
            yeniklon.transform.position = new Vector3(solkisim, karakter.transform.position.y, karakter.position.z + 6);
        }
        if (sayi < 30)
        {
            yeniklon.transform.position = new Vector3(ortakisim, karakter.transform.position.y, karakter.position.z + 6);
        }
    }
}
