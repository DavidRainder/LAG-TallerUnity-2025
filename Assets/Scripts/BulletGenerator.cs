using Unity.VisualScripting;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;

    [SerializeField]
    private Transform _generationPoint = null;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!_generationPoint)
        {
            Debug.LogError("No hay punto de generación de bala");
        }
    }

    void GenerateBullet(Vector3 dir) {
        GameObject bala = Instantiate(_bullet, _generationPoint.position, _bullet.transform.rotation);
        MoveUp moveup = bala.GetComponent<MoveUp>();
        moveup.SetDir(dir);
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.W)) {
        //    GenerateBullet(Vector3.up);            
        //}
        //if(Input.GetKeyDown(KeyCode.A)) {
        //    GenerateBullet(Vector3.left);            
        //}
        //if(Input.GetKeyDown(KeyCode.S)) {
        //    GenerateBullet(Vector3.down);            
        //}
        //if(Input.GetKeyDown(KeyCode.D)) {
        //    GenerateBullet(Vector3.right);            
        //}

        if(Input.GetKeyDown(KeyCode.Space)) {
            GenerateBullet(_generationPoint.forward);
        }
    }
}
