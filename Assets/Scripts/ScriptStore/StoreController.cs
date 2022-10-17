using UnityEngine;
using UnityEngine.UI;

public class StoreController : MonoBehaviour
{
    [SerializeField] private Text moneyText;
    public int money = 100;
    [SerializeField]private GameObject[] defenses;
    public bool isEditing;
    public static StoreController instance;

    private void Start()
    {
        instance = this;
    }

    public void EditToggle(bool toggle)
    {
        isEditing = toggle;
    }

    public void SummonConstruction(int construction)
    {
        Defense currentConstruction = defenses[construction].GetComponent<Defense>();
        if(money >= currentConstruction.price[0])
        {
            Instantiate(defenses[construction], new Vector3(0, 0, 18), defenses[construction].transform.rotation);
            money -= currentConstruction.price[0];
            moneyText.text = $"Money: " + money;
        }
    }

    public void GainMoney(int ammount)
    {
        money += ammount;
        moneyText.text = $"Money: " + money;
    }
}
