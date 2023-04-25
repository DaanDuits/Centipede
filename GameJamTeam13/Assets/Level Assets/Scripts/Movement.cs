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
        transform.position += transform.forward * yInput * Time.deltaTime * 12;
        if (yInput > 0 || yInput < 0)
            transform.eulerAngles += transform.up * xInput * Time.deltaTime * 100;
        Camera.main.transform.rotation= Quaternion.Slerp(Camera.main.transform.rotation, transform.rotation, Time.deltaTime * 5);
        Camera.main.transform.rotation = Quaternion.Euler(25, Camera.main.transform.eulerAngles.y, 0);
        Camera.main.transform.position = Vector3.Slerp(Camera.main.transform.position, transform.position - (transform.forward * 17) + transform.up * 9, Time.deltaTime * 10);
    }
}
