using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private string horizontalinput,verticalinput;
    [SerializeField] private float speed;
    private CharacterController control;

    private void Awake()
    {
        control = GetComponent<CharacterController>();
    }
   
    private void Update()
    {
        PlayerMovement();
    }
    private void PlayerMovement()
    {
        float horizinput = Input.GetAxis(horizontalinput) * speed ;
        float vertinput = Input.GetAxis(verticalinput) * speed ;
        Vector3 forward = transform.forward * vertinput;
        Vector3 side = transform.right * horizinput;
        control.SimpleMove(forward + side);
    }
}
