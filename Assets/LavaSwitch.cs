using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaSwitch : MonoBehaviour
{
    public MeshRenderer render;

    public float x;
    public float y;
    public bool switched = false;

    // Start is called before the first frame update
    void Start()
    {
        render.material.SetFloat("_ScrollX", x);
        render.material.SetFloat("_ScrollY", x);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && !switched)
        {
            render.material.SetFloat("_ScrollX", x);
            render.material.SetFloat("_ScrollY", x);
            switched = true;
        }
        else if (Input.GetKeyDown(KeyCode.P) && switched)
        {
            render.material.SetFloat("_ScrollX", y);
            render.material.SetFloat("_ScrollY", y);
            switched = false;
        }
    }
}
