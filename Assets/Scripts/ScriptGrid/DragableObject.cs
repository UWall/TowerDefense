using UnityEngine;

public class DragableObject : MonoBehaviour
{
    [SerializeField]private GridCell currentCell = null, previousCell = null;
    private GridCell CheckForCell()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(mouseRay, out RaycastHit raycastHit) == true)
        {
            return raycastHit.transform.gameObject.GetComponent<GridCell>();
        }
        else
        {
            return null;
        }
    }

    private void OnMouseDrag()
    {
        if (MouseRaycast.MousePos() != Vector3.zero && StoreController.instance.isEditing)
        {
            transform.position = MouseRaycast.MousePos();
            if(CheckForCell() != null)
            {
                previousCell = currentCell;
                currentCell = CheckForCell();
                if(previousCell != null)
                {
                    previousCell.currentObject = null;
                    previousCell.isOccupied = false;
                }
                
                if(currentCell.isOccupied == false)
                {
                    currentCell.currentObject = gameObject;
                    currentCell.isOccupied = true;
                }
            }
        }
    }

    private void OnMouseUp()
    {
        if(currentCell != null)
        {
            transform.position = currentCell.transform.position;
        }
    }
}
