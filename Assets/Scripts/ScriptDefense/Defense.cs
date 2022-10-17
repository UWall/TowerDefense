using UnityEngine;

public class Defense : MonoBehaviour
{
    [SerializeField] private DefenseData data;
    public int[] price;
    public float[] attackSpeed, attackDamage, attackRange;
    public GameObject gun, projectile;
    public int currentUpgrade = 0;
    private int target = 0;
    private float cooldown;
    private void Start()
    {
        price = data.price;
        attackSpeed = data.attackSpeed;
        attackDamage = data.attackDamage;
        attackRange = data.attackRange;
        projectile = data.projectile;
    }

    private void FixedUpdate()
    {
        if(StoreController.instance.isEditing == false)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Collider[] enemies = Physics.OverlapSphere(transform.position, attackRange[currentUpgrade]);
        if (target >= enemies.Length)
        {
            target = 0;
        }
        if (enemies.Length > 0)
        {
            if (enemies[target].gameObject.CompareTag("Enemy") == true)
            {
                transform.LookAt(enemies[target].gameObject.transform.position);
                if(Time.time >= cooldown)
                {
                    Instantiate(projectile, gun.transform.position, gun.transform.rotation);
                    cooldown = Time.time + attackSpeed[currentUpgrade];
                }
            }
            else
            {
                target++;
                transform.rotation = Quaternion.Euler(0, 45, 0);
            }
        }
    }

    private void Upgrade()
    {
        if (currentUpgrade != price.Length)
        {
            if (StoreController.instance.money >= price[currentUpgrade + 1])
            {
                StoreController.instance.money -= price[currentUpgrade + 1];
                currentUpgrade++;
            }
        }
    }
}
