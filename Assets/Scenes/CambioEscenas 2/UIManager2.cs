using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager2 : MonoBehaviour
{
   [SerializeField] TextMeshProUGUI usuario;
    public void changeScene(int indexNewScene)
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.buildIndex == 3)
        {
            string usu = usuario.text;
            PlayerPrefs.SetString("usuario", usu);
        }
        SceneManager.LoadScene(indexNewScene);
    }
   
    
       
    

    public void Update()
    {
        
       
    }
}
