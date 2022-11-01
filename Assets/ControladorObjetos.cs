using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControladorObjetos : MonoBehaviour
{
    private bool botella;
    private bool lata;

    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        botella = false;
        lata = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(botella && lata){
            SceneManager.LoadScene(sceneName);
        }
    }
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Botella"))
        {
            botella = true;
        }
        if (other.gameObject.CompareTag("Lata"))
        {
            lata = true;
        }
    }
}
