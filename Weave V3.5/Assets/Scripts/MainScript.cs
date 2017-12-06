using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainScript : MonoBehaviour {

    int Keys;
    int Keys2;
    public float SpeedCD = 5; //added 10-11
    public float CD;

    Rigidbody rb;
    public float thrustAmt;
    public GameObject Door;
    public GameObject Door2;
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Camera camera4;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
        camera4.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {


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

        if (CD > 0)
        {         //added line 41 - 48 and line 55
            CD -= Time.deltaTime;
        }

        if (CD < 0)
        {
            CD = 0;
            Physics.gravity = new Vector3(0f, -20f, 0f);
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Change left"))
        {
            Physics.gravity = new Vector3(-15f, -5f, 10f);
            camera1.enabled = false;
            camera2.enabled = true;
            camera3.enabled = false;
            camera4.enabled = false;
        }

        if (other.gameObject.CompareTag("Change Up"))
        {
            Physics.gravity = new Vector3(0f, 5f, 12f);
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = true;
            camera4.enabled = false;
        }

        if (other.gameObject.CompareTag("Change Right"))
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
        if (other.gameObject.CompareTag("Key"))
        {
            other.gameObject.SetActive(false);
            Keys = Keys + 1;
        }
        if (other.gameObject.CompareTag("Key2"))
        {
            other.gameObject.SetActive(false);
            Keys2 = Keys2 + 1;
        }
        if (Keys == 1)
        {
            GameObject.DestroyObject(Door);
        }
        if (Keys2 == 1)
        {
            GameObject.DestroyObject(Door2);
        }

        if (other.gameObject.CompareTag("Boost"))
        {
            Physics.gravity = new Vector3(0f, -20f, 10f);
            CD = SpeedCD;
        }

        if (other.gameObject.CompareTag("Death"))
        {
            SceneManager.LoadScene("Instruction");
        }

        if (other.gameObject.CompareTag("Win"))
        {
            SceneManager.LoadScene("Win");
        }

        if (other.gameObject.CompareTag("Win2"))
        {
            SceneManager.LoadScene("Win 2");
        }

        if (other.gameObject.CompareTag("Win3"))
        {
            SceneManager.LoadScene("Win 3");
        }

        if (other.gameObject.CompareTag("Lose"))
        {
            SceneManager.LoadScene("Lose");
        }

        if (other.gameObject.CompareTag("Lose2"))
        {
            SceneManager.LoadScene("Lose2");
        }

        if (other.gameObject.CompareTag("Lose3"))
        {
            SceneManager.LoadScene("Lose3");
        }

    }
}
