using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_DestruyeObjetos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject g = collision.gameObject;

        if (g.CompareTag("Enemigo"))
        {
            Destroy(g);
        }
       // Destroy(g, 3f); //tiempo para destruir el objeto en este caso 3f = segundos  3 
    }
}
