using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class spawn : MonoBehaviour {
	public GameObject zombie;
	Transform spawnz;
	//NavMeshAgent nav;
	public Transform MainCamera;
	GameObject clone;
	// Use this for initialization
	void Start () {		
		InvokeRepeating ("spawnerZombie", 2f, 10f);
		spawnz = GetComponent<Transform> ();

	}
	void spawnerZombie(){
		clone = Instantiate(zombie,spawnz.position,spawnz.rotation);
		clone.GetComponent<NavMeshAgent>().SetDestination(MainCamera.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
