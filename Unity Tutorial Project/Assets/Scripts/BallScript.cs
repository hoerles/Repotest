using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {
	
	public AudioClip[] blipAudio;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Die() {
		 
		GameObject paddleObject = GameObject.Find("paddle");
		PaddleScript paddleScript = paddleObject.GetComponent<PaddleScript>();
		paddleScript.LoseLife();
		Debug.Log("vonGitExtensions3"); 
		Debug.Log("vonGitHub4444");
		Debug.Log("vonGitExtensions1");
		Debug.Log("vonGitHub4444"); 
	}
	
	void OnCollisionEnter( Collision collision ) { 
		if(collision.gameObject.name == "brickRed"){
			AudioSource.PlayClipAtPoint(blipAudio[3], transform.position, 1.25f);
			Debug.Log ("Mamamma");
		}
		else {
			AudioSource.PlayClipAtPoint(blipAudio[ Random.Range(0, 2) ], transform.position, .25f);
		}
	}
}
