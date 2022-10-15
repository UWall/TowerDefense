using UnityEngine;

    [CreateAssetMenu(fileName = "Defense", menuName = "New Defense")]
public class DefenseData : ScriptableObject
{
    public int[] price;
    public float[] attackSpeed, attackDamage, attackRange;
}
