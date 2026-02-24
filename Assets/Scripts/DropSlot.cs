using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public Image targetBodyPart; // <-- Tēla Image, kur jāparādās sprite

    public void OnDrop(PointerEventData eventData)
    {
        DragScript dragged = eventData.pointerDrag.GetComponent<DragScript>();

        if (dragged != null)
        {
            // Uzliek sprite uz tēla
            targetBodyPart.sprite = dragged.itemSprite;
        }
    }
}