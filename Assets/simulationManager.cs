using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simulationManager : MonoBehaviour
{
	// dios de la simulacion, ambiente con sus caracteristicas
	// arreglo de bacterias 
	// metodos que se hagan sobre bacterias

	public GameObject Bacilo;  //objetos listos para instanciarse 
	public List<GameObject> bacterias = new List<GameObject>();
	private float escala = 0.001f;

	// caracteristicas de las bacterias
	public int cantidad;

	// Start is called before the first frame update
	void Start()
	{
		// crear n cantidad de bacterias
		for (int i = 0; i < cantidad; i++)
		{	
			float rotation = Random.Range(0, 360);
			float x = Random.Range(-49f,49f);
			float z = Random.Range(-49f,49f);
			GameObject bc = Instantiate(Bacilo, new Vector3(x, 0, z), Quaternion.Euler(90f, 0f,rotation));
			bacterias.Add(bc);
		}
	}


	// Update is called once per frame
	void Update()
	{
		List<GameObject> bacterias_actuales = new List<GameObject>(bacterias);

		foreach (var bc in bacterias_actuales)
		{
			bc.transform.localScale += new Vector3(0, escala, 0);
			bool dar_nutriente = bc.GetComponent<bacilo_script>().agregar_nutriente(escala);

			if (dar_nutriente)
			{
				dividir_bacilo(bc); 
			}

		}
	}
	void dividir_bacilo (GameObject bc){
			GameObject bc1 = Instantiate(Bacilo, bc.transform.position + (bc.transform.localScale.y * bc.transform.up.normalized)/1.3f , bc.transform.rotation);
			GameObject bc2 = Instantiate(Bacilo, bc.transform.position - (bc.transform.localScale.y * bc.transform.up.normalized)/1.3f , bc.transform.rotation);
			bc1.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
			bc2.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);

			bacterias.Add(bc1);
			bacterias.Add(bc2);
			
			bacterias.Remove(bc);
			Destroy(bc); 
			Debug.Log("bacilo dividido");
		}
		
			
		
	
}
