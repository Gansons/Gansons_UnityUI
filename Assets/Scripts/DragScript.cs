using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragScript : MonoBehaviour, IDropHandler
{
    public Image targetBodyPart; // piemēram: RightHandImage vai LeftHandImage

    public void OnDrop(PointerEventData eventData)
    {
        Image draggedImage = eventData.pointerDrag.GetComponent<Image>();

        if (draggedImage != null)
        {
            // Uzliek sprite uz tēla
            targetBodyPart.sprite = draggedImage.sprite;
        }
    }
}