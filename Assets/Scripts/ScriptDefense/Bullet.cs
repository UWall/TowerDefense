using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]private float speed;

    private void Start()
    {
        Invoke("Die", 7.5f);
    }
    
    private void FixedUpdate()
    {
        if(StoreController.instance.isEditing == false)
        {
            transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy") == true)
        {
            other.GetComponent<Enemy>().TakeDamage();
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
