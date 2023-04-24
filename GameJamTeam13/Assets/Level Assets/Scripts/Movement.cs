using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float yInput = Input.GetAxis("Vertical");
        float xInput = (Input.mousePosition.x / Screen.width) * 2 - 1;
        transform.position += transform.forward * yInput * Time.deltaTime * 5;
        if (yInput > 0 || yInput < 0)
            transform.eulerAngles += transform.up * xInput * Time.deltaTime * 100;
    }
}
