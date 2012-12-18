using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour
{

    public GameObject g;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            g.renderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
