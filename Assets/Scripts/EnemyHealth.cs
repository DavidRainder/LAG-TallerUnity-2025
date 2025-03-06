using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        MoveUp moveUp = collision.collider.GetComponent<MoveUp>();
        if(moveUp != null)
        {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }   
    }
}
