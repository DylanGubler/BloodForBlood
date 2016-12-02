using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	[SerializeField]
	int Health = 100;

	[SerializeField]
	Transform target;

	[SerializeField]
	Animator myAnimator;

	[SerializeField]
	AudioSource myAudioSource;

	public void Damage(int points, Transform newTarget)
	{
		Health -= points;
		if (Health <= 0)
			Destroy (gameObject);
		else {
			target = newTarget;
			myAudioSource.Play ();
		}			
	}

	void Update()
	{
		if (target) {
			GetComponent<NavMeshAgent> ().SetDestination (target.position);
			float distance = Vector3.Distance (target.position, transform.position);
			print (distance);
			if (distance > 2.5f)
				myAnimator.SetBool ("IsWalking", true);
			else
				myAnimator.SetBool ("IsWalking", false);
		}
	}
}
