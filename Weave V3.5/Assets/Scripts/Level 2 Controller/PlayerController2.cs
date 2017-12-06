using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController2 : MonoBehaviour {


	Rigidbody rb;
	public float thrustAmt;
	public Camera camera1;
	public Camera camera2;
	public Camera camera3;
	public Camera camera4;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		camera1.enabled = true;
		camera2.enabled = false;
		camera3.enabled = false;
		camera4.enabled = false;
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("LevelSelect");
        }
        if (camera1.enabled == true) // regular
		{

			if (Input.GetKey(KeyCode.A))
			{
				rb.AddForce(Vector3.left * thrustAmt);
			}

			if (Input.GetKey(KeyCode.S))
			{
				rb.AddForce(Vector3.back * thrustAmt);
			}

			if (Input.GetKey(KeyCode.D))
			{
				rb.AddForce(Vector3.right * thrustAmt);
			}

			if (rb.position.y < -1f)
			{
				FindObjectOfType<GameManager>().EndGame();
			}

		}
		if (camera2.enabled == true) //left
		{
			if (Input.GetKey(KeyCode.A))
			{
				rb.AddForce(Vector3.up * thrustAmt);
			}

			if (Input.GetKey(KeyCode.S))
			{
				rb.AddForce(Vector3.left * thrustAmt);
			}

			if (Input.GetKey(KeyCode.D))
			{
				rb.AddForce(Vector3.down * thrustAmt);
			}
		}
		if (camera3.enabled == true) //upside down
		{
			if (Input.GetKey(KeyCode.A))
			{
				rb.AddForce(Vector3.right * thrustAmt);
			}

			if (Input.GetKey(KeyCode.S))
			{
				rb.AddForce(Vector3.up * thrustAmt);
			}

			if (Input.GetKey(KeyCode.D))
			{
				rb.AddForce(Vector3.left * thrustAmt);
			}
		}
		if (camera4.enabled == true) //right
		{
			if (Input.GetKey(KeyCode.A))
			{
				rb.AddForce(Vector3.down * thrustAmt);
			}

			if (Input.GetKey(KeyCode.S))
			{
				rb.AddForce(Vector3.right * thrustAmt);
			}

			if (Input.GetKey(KeyCode.D))
			{
				rb.AddForce(Vector3.up * thrustAmt);
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Change left")) {
			Physics.gravity = new Vector3 (-15f, -5f, 10f);
			camera1.enabled = false;
			camera2.enabled = true;
			camera3.enabled = false;
			camera4.enabled = false;
		}   

		if (other.gameObject.CompareTag ("Change Up"))
		{
			Physics.gravity = new Vector3(0f, 5f, 12f);
			camera1.enabled = false;
			camera2.enabled = false;
			camera3.enabled = true;
			camera4.enabled = false;
		}

		if (other.gameObject.CompareTag ("Change Right"))
		{
			Physics.gravity = new Vector3(15f, -5f, 10f);
			camera1.enabled = false;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled = true;
		}

		if (other.gameObject.CompareTag("Normal"))
		{
			Physics.gravity = new Vector3(0f, -10f, 0f);
			camera1.enabled = true;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled = false;
		}
        if (other.gameObject.CompareTag("Death"))
        {
            SceneManager.LoadScene("Instruction");
        }
    }
}
