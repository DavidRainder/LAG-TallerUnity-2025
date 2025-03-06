using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform _myTransform = null;

    void Start() {
        _myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        _myTransform.position += Vector3.right * horizontalMovement * 1.0f * Time.deltaTime;
        _myTransform.position += Vector3.forward * verticalMovement * 1.0f * Time.deltaTime;
    }
}
