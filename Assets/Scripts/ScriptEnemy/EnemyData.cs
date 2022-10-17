using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "New Enemy")]

public class EnemyData : ScriptableObject
{
    public float health, speed;
    public int lootValue, scoreValue;
}
