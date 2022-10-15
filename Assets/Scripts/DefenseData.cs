using UnityEngine;

    [CreateAssetMenu(fileName = "Defense", menuName = "New Defense")]
public class DefenseData : ScriptableObject
{
    [SerializeField]private int[] price;
    [SerializeField]private float[] attackSpeed, attackDamage, attackRange;
}
