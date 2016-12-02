using UnityEngine;
using System.Collections;

public class WeaponChanger : MonoBehaviour {

	[SerializeField]
	GameObject Bow;

	[SerializeField]
	GameObject Sword;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			Bow.SetActive (false);
			Sword.SetActive (true);
		}

		else if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			Bow.SetActive (true);
			Sword.SetActive (false);
		}
		
	}
}
