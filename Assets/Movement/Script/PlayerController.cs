using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed; 
    public float jumpforce;
    public float gravityScale=5f;

    private Vector3 moveDirection;

    public CharacterController charController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yStore = moveDirection.y;
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveDirection = moveDirection * moveSpeed;
        moveDirection.y= yStore;

        if (Input.GetButtonDown("Jump"))
        {
            moveDirection.y = jumpforce;
        }
        moveDirection.y += Physics.gravity.y*Time.deltaTime*gravityScale;
        charController.Move(moveDirection * Time.deltaTime);
    }
}
