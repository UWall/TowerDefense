using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Image HP;
    [SerializeField] private Text scoreText;
    private int score, difficulty = 1;

    public static GameController instance;

    private void Start()
    {
        instance = this;
    }

    public void GainScore(int ammount)
    {
        score += ammount;
        Debug.Log(score / 5);
        scoreText.text = "Score: " + score;
        if(score / 5 == difficulty)
        {
            EnemySpawner.instancce.SpawnEnemy(difficulty);
            difficulty++;
        }
    }

    public void TakeDamage()
    {
        HP.fillAmount -= 0.25f;
        if(HP.fillAmount <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
