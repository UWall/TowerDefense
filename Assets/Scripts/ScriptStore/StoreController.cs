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
}
