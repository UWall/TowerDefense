using UnityEngine;

public class StoreController : MonoBehaviour
{
    public int money;
    [SerializeField]private GameObject[] defenses;
    public static StoreController instance;

    private void Start()
    {
        instance = this;
    }

    public void SummonConstruction(int construction)
    {
        Defense currentConstruction = defenses[construction].GetComponent<Defense>();
        if(currentConstruction.price[0] < money)
        {
            Instantiate(defenses[construction], MouseRaycast.MousePos(), transform.rotation);
            money -= currentConstruction.price[construction];
        }
    }
}
