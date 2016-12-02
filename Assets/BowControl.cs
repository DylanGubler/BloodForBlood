using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class BowControl : MonoBehaviour {

	[SerializeField]
	Animator myAnimator;

	[SerializeField]
	AudioSource myAudiosource;

	[SerializeField]
	GameObject PlayerFPCamera;

	void Update () {
		if (CrossPlatformInputManager.GetButtonDown ("Fire1")) 
		{
			myAnimator.SetTrigger ("Shoot");
			myAudiosource.Play ();

			RaycastHit hit;
			if (Physics.Raycast (PlayerFPCamera.transform.position,
				    PlayerFPCamera.transform.forward, out hit)) 
			{
				GameObject target = hit.collider.transform.gameObject;
				print (target.name);
				EnemyScript enemy = target.GetComponent<EnemyScript> ();
				if (enemy)
					enemy.Damage (50,PlayerFPCamera.transform);
			}
		}
	}
}
