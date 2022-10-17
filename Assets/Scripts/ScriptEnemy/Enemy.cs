using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyData data;
    [SerializeField]private float health, speed;
    [SerializeField]private int lootValue, scoreValue;
    [SerializeField] private GameObject[] nextPoints;
    private int currentPoint;

    private void Start()
    {
        health = data.health;
        speed = data.speed;
        lootValue = data.lootValue;
        scoreValue = data.scoreValue;

        currentPoint = Random.Range(0, nextPoints.Length);
        transform.position = nextPoints[currentPoint].transform.position;
    }

    private void FixedUpdate()
    {
        if(StoreController.instance.isEditing == false)
        {
            Move();
        }
    }

    private void Move()
    {
        Vector3 dir = nextPoints[currentPoint].transform.position - transform.position;
        if (dir.magnitude < 0.1f)
        {
            ChooseNewPath();
        }
        transform.position += dir.normalized * speed * Time.fixedDeltaTime;
    }

    private void ChooseNewPath()
    {
        nextPoints = nextPoints[currentPoint].GetComponent<PointData>().nextPoints;
        currentPoint = Random.Range(0, nextPoints.Length);
    }

    public void TakeDamage()
    {
        health--;
        if(health <= 0)
        {
            StoreController.instance.GainMoney(lootValue);
            GameController.instance.GainScore(scoreValue);
            EnemySpawner.instancce.SpawnEnemy(5);
            Destroy(gameObject);
        }
    }
}
