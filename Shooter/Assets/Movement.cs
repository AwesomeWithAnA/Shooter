using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    private CharacterController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 transforminput = transform.TransformDirection(input);
        Vector3 moveDirection = transforminput*Time.deltaTime*speed;
        moveDirection.y -= 9.81f * Time.deltaTime;
        controller.Move(moveDirection);

    }
}
