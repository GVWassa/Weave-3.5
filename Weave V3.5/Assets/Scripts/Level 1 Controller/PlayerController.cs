using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	int Keys;
	int Keys2;
	Rigidbody rb;
	public float thrustAmt;
	public GameObject Door;
	public GameObject Door2;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();


	}

	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.A)) {
			rb.AddForce (Vector3.left * thrustAmt);
		}

		if (Input.GetKey (KeyCode.S)) {
			rb.AddForce (Vector3.back * thrustAmt);
		}

		if (Input.GetKey (KeyCode.D)) {
			rb.AddForce (Vector3.right * thrustAmt);
		}

		if (rb.position.y < -1f) {
			FindObjectOfType<GameManager> ().EndGame ();
		}
		if (Keys == 1) {
			GameObject.DestroyObject (Door);
		}
		if (Keys2 == 1) {
			GameObject.DestroyObject (Door2);
		}

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("LevelSelect");
        }
	}
		void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Key")) {
			other.gameObject.SetActive (false);
			Keys = Keys + 1;
		}
		if (other.gameObject.CompareTag ("Key2")) {
			other.gameObject.SetActive (false);
			Keys2 = Keys2 + 1;
		}

        if (other.gameObject.CompareTag("Death"))
        {
            SceneManager.LoadScene("Instruction");
        }
    }
}

