using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloomManager : MonoBehaviour
{
    Bloom _switch;

    // Start is called before the first frame update
    void Start()
    {
        _switch = GetComponent<Bloom>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            _switch.enabled = !_switch.enabled;
        }
    }
}
