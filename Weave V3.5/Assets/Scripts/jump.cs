using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

	
	Rigidbody rb;
	public GameObject Jumper;
	public Camera Camera;

	//public float Delay;
	//float timer;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		//Delay = 10;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//timer += Time.deltaTime;

		//if(timer > Delay){
		//Camera.main.transform.Rotate(new Vector3(0, 0, 180));
		//}
	}

	void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Jumper"))
        {


            rb.AddForce(0.0f, 10.0f, 0f,ForceMode.Acceleration);

        }
        else if(col.gameObject.name == "Bumper1")
        { 
            rb.AddForce (0.0f, 500.0f,100.0f );
        }

        else if(col.gameObject.name == "Bumper2")
        {
            rb.AddForce(0.0f, 200.0f, 400.0f);
        }
    }

}

// Source timer: https://answers.unity.com/questions/1270166/how-to-move-an-object-after-an-amount-of-time.html