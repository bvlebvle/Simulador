using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour

{
    public GameObject bacilo;
    // Start is called before the first frame update
    void Start()
    {}
    // Update is called once per frame
    void Update()
    {}
    void OnCollisionEnter()
    {
      //Debug.Log("colision inicio");
      //bacilo.GetComponent<Rigidbody>().isKinematic = false;
        bacilo.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
    }
     void OnCollisionStay(){
        //Debug.Log("colision medio");
        //bacilo.GetComponent<Rigidbody>().isKinematic = false;
         bacilo.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
    }
    void OnCollisionExit(){
         bacilo.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        //Debug.Log("colision fin");
        //bacilo.GetComponent<Rigidbody>().isKinematic = true;
    }
}
