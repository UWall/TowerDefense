using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]private GameObject[] enemies;
    public static EnemySpawner instancce;

    private void Start()
    {
        instancce = this;
        Invoke("SummonEnemy", 10);
    }

    public void SpawnEnemy(int time)
    {
        Invoke("SummonEnemy", time);
    }

    private void SummonEnemy()
    {
        int rng = Random.Range(0, enemies.Length);
        GameObject enemy = Instantiate(enemies[rng], transform.position, Quaternion.Euler(0, 45, 0));
        enemy.SetActive(true);
    }
}
