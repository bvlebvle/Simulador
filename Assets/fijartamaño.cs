using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fijartamaño : MonoBehaviour
{
    Transform tf; 
    public Transform cilinder;

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        tf.localScale = new Vector3(tf.localScale.x,1/cilinder.localScale.y,tf.localScale.z);
        
    }
}
