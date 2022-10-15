using UnityEngine;

public class MouseRaycast : MonoBehaviour
{
    public static Vector3 MousePos()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(mouseRay, out RaycastHit raycastHit) == true)
        {
            return raycastHit.transform.position;
        }
        else
        {
            return Vector3.zero;
        }
    }
}
