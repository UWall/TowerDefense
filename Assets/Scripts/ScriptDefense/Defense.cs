using UnityEngine;

public class Defense : MonoBehaviour
{
    [SerializeField]private DefenseData data;
    public int[] price;
    public float[] attackSpeed, attackDamage, attackRange;
    private void Start()
    {
        price = data.price;
        attackSpeed = data.attackSpeed;
        attackDamage = data.attackDamage;
        attackRange = data.attackRange;
    }
}
