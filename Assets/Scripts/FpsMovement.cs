using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CharacterController))]

// basic WASD-style movement control
public class FpsMovement : MonoBehaviour
{
    [SerializeField] private Camera headCam;

    public float speed = 6.0f;
    public float gravity = -9.8f;

    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    private float rotationVert = 0;

    private CharacterController charController;

    public Interactable focus;

    public CursorLockMode wantedMode;

    void Start()
    {
        Cursor.lockState = wantedMode;
        charController = GetComponent<CharacterController>();
        Cursor.visible = (CursorLockMode.Locked != wantedMode);
    }

    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        MoveCharacter();
        RotateCharacter();
        RotateCamera();
        Interaction();
    }
    private void Interaction()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hit;

            RaycastHit hit;
            Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward, color: Color.white, duration: 2f);
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            if (Physics.Raycast(ray, out hit, 1000, 11))
            {
                /*if(hit.collider.tag!="Player"&&hit.collider.tag!="Enemy")
            {
                position = hit.point;
            }*/

                Interactable interactable = hit.collider.GetComponent<Interactable>();
            
                if (interactable != null)
                {
                    SetFocus(interactable);
                }
                else
                {
                    Inventory.instance.activeItem = null; //If we didn't hit an item, turn off the using item display
                    //TODO: This should be decided.
                }


            }
        }
    }

    void SetFocus(Interactable newFocus)
    {
        // If our focus has changed
        if (newFocus != focus)
        {
            // Defocus the old one
            if (focus != null)
                focus.OnDefocused();

            focus = newFocus;   // Set our new focus
                                //motor.FollowTarget(newFocus);	// Follow the new focus
        }

        newFocus.OnFocused(transform);
    }

    // Remove our current focus
    void RemoveFocus()
    {
        if (focus != null)
            focus.OnDefocused();

        focus = null;
        //motor.StopFollowingTarget();
    }


    // Update is called once per frame

    private void MoveCharacter()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;

        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);

        charController.Move(movement);
    }

    private void RotateCharacter()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
    }

    private void RotateCamera()
    {
        rotationVert -= Input.GetAxis("Mouse Y") * sensitivityVert;
        rotationVert = Mathf.Clamp(rotationVert, minimumVert, maximumVert);

        headCam.transform.localEulerAngles = new Vector3(
            rotationVert, headCam.transform.localEulerAngles.y, 0
        );
    }
}
