using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 6f;
    public float rotationSpeed = 10f;
    private Rigidbody rb;
    Camera viewCamera;
    Vector3 velocity;

    void Start() {
        rb = GetComponent<Rigidbody>();
        viewCamera = Camera.main;
    }

    void Update() {
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        //transform.LookAt(mousePos + Vector3.up * transform.position.y);
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * moveSpeed;


        Quaternion targetRotation = Quaternion.LookRotation(mousePos - transform.position);
        targetRotation.z = 0;
        targetRotation.x = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + velocity * Time.deltaTime);
    }
}