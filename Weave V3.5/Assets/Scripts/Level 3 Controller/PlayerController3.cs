using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController3 : MonoBehaviour {


	Rigidbody rb;
	public float thrustAmt;
	public float SpeedCD = 5; //added 10-11
	public float CD;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();


	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("LevelSelect");
        }

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


		if (CD > 0) {         //added line 41 - 48 and line 55
			CD -= Time.deltaTime;
		}

		if (CD < 0) {
			CD = 0;
			Physics.gravity = new Vector3 (0f, -20f, 0f);

		}
	}
	void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.CompareTag("Player")){
			Physics.gravity = new Vector3 (0f, -100f, 0f);
			CD = SpeedCD;
		}
        if (other.gameObject.CompareTag("Death"))
        {
            SceneManager.LoadScene("Instruction");
        }

    }
}			

