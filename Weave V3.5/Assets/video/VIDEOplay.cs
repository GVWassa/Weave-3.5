using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VIDEOplay : MonoBehaviour {
    public MovieTexture movTexture;
    void Start() {
        GetComponent<Renderer>().material.mainTexture = movTexture;
        movTexture.Play();
    }
}