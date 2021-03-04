using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1sc : MonoBehaviour
{
    public GameObject butonres;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tekrarla()
    {
        SceneManager.LoadScene("Level2");
        
    }
}
