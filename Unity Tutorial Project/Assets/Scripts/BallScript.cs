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
		Destroy( gameObject );
		GameObject paddleObject = GameObject.Find("paddle");
		PaddleScript paddleScript = paddleObject.GetComponent<PaddleScript>();
		paddleScript.LoseLife();
	}
	
	void OnCollisionEnter( Collision collision ) { 
		if(collision.gameObject.name == "brickRed"){
			AudioSource.PlayClipAtPoint(blipAudio[3], transform.position, 1.25f);
		}
		else {
			AudioSource.PlayClipAtPoint(blipAudio[ Random.Range(0, 2) ], transform.position, .25f);
		}
	}
}
