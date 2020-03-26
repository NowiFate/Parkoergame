using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3.5f;
    public float jumpHeight = 30f;
    public float dashBoost = 600f;
    private Rigidbody rb;
    public GameObject groundCheck;
    
    //for crouching
    public Collider CrouchCollider;
    public Collider NormalCollider;
    public MeshRenderer NormalRenderer;
    public MeshRenderer CrouchRenderer;
    public Camera mainCamera;
    public Camera crouchCamera;

    private void Awake()
    {
        rb = GetComponentInChildren<Rigidbody>();
    }

    // Start is called before the first frame update
    private void Start()    
    {

    }

    // Update is called once per frame
    private void Update()
    {
        //Move
        float vert = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        Vector3 moveDir = vert * transform.forward + hor * transform.right;
     
        rb.MovePosition(transform.position + moveDir.normalized * Time.deltaTime * moveSpeed);

        //Jump
        RaycastHit hit;
        if (Physics.Raycast(groundCheck.transform.position, -Vector3.up, out hit, 1f)) {
   
            if (Input.GetKeyDown(KeyCode.Space)) {

                rb.AddForce(Vector3.up * jumpHeight);
            }

        }

        //Crouch
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //collider small
            //camera position update
            CrouchCollider.enabled = true;
            CrouchRenderer.enabled = true;
            NormalCollider.enabled = false;
            NormalRenderer.enabled = false;
            crouchCamera.enabled = true;
            mainCamera.enabled = false;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            //collider big
            //camera position update
            CrouchCollider.enabled = false;
            CrouchRenderer.enabled = false;
            NormalCollider.enabled = true;
            NormalRenderer.enabled = true;
            crouchCamera.enabled = false;
            mainCamera.enabled = true;
        }
    }
}
