using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_CreaEnemigo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject PlantillaEnemigo;
    [SerializeField] List<GameObject> Spawns;

    public int index_new_enemy;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            index_new_enemy = Random.Range(0, 8);

            GameObject nlocation = Spawns[index_new_enemy];

            GameObject objNuevo = Instantiate(PlantillaEnemigo, nlocation.transform.position, nlocation.transform.rotation);
        }
    }
}
