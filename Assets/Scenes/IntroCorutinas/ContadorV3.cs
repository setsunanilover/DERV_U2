using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ContadorV3 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt_contador;
    [SerializeField] int contador =0;
    
    // Start is called before the first frame update
    void Start()
    {
        contador = 10;
       

        StopAllCoroutines();
        StartCoroutine("Contador");
    }

    // Update is called once per frame
    void Update()
    {   
    }
    IEnumerator Contador()

    {
        while (contador > -1)
        {
            txt_contador.text = contador.ToString();
            contador--;
            yield return new WaitForSeconds(1);
        }
    }
}
