using UnityEngine;

public class MoveUp : MonoBehaviour
{
    [SerializeField]
    Vector3 dir = new Vector3(0,1,0);

    public void SetDir(Vector3 value) {
        dir = value;
    }

    [SerializeField, Range(0, 10)]
    private float _speed;
    private Transform _myTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _myTransform.position += dir * Time.deltaTime;
    }
}
