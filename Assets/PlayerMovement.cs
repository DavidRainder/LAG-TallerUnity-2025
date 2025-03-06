using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform _myTransform = null;
    Rigidbody _rb;

    float horizontalMovement;
    float verticalMovement;

    void Start() {
        _myTransform = GetComponent<Transform>();
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        //_myTransform.position += Vector3.right * horizontalMovement * 1.0f * Time.deltaTime;
        //_myTransform.position += Vector3.forward * verticalMovement * 1.0f * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        _rb.linearVelocity = new Vector3(horizontalMovement * 5.0f, 0, verticalMovement * 5.0f);
    }
}
