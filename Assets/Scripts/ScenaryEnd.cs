using UnityEngine;

public class ScenaryEnd : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        GameController.instance.TakeDamage();
        EnemySpawner.instancce.SpawnEnemy(5);
    }
}
