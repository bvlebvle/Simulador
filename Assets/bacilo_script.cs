using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bacilo_script : MonoBehaviour
{
    public float nutriente = 0f;
    private float nutriente_max = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //dar de comer a la bacteria
    public bool agregar_nutriente(float nutriente_agregar)
    {
        nutriente += nutriente_agregar;
        if (nutriente > nutriente_max)
        {
            return true;
        }

        return false;
    }

}
