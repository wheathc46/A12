using System.Collections;
using System.Collections.Generic;
Using Unity Engine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 5;
	public Rigidbody rb;
	flat HorizontalInput;
	public float horizontalMultiplier = 2;

	private void FixedUpdate(){

	Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
	Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
	rb.MovePosition(rb.position + forwardMove + horizontalMove);
	}
    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
    }
}
