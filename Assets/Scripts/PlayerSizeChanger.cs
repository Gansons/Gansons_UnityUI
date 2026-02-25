using UnityEngine;

public class DualCharacterSizeChanger : MonoBehaviour
{
    public Transform banditRoot;
    public Transform knightRoot;

    [Header("Limits")]
    public float minWidth = 0.8f;
    public float maxWidth = 1.4f;
    public float minHeight = 0.8f;
    public float maxHeight = 1.4f;

    public void SetWidth(float value)
    {
        value = Mathf.Clamp(value, minWidth, maxWidth);

        if (banditRoot != null)
        {
            Vector3 scale = banditRoot.localScale;
            scale.x = value;
            banditRoot.localScale = scale;
        }

        if (knightRoot != null)
        {
            Vector3 scale = knightRoot.localScale;
            scale.x = value;
            knightRoot.localScale = scale;
        }
    }

    public void SetHeight(float value)
    {
        value = Mathf.Clamp(value, minHeight, maxHeight);

        if (banditRoot != null)
        {
            Vector3 scale = banditRoot.localScale;
            scale.y = value;
            banditRoot.localScale = scale;
        }

        if (knightRoot != null)
        {
            Vector3 scale = knightRoot.localScale;
            scale.y = value;
            knightRoot.localScale = scale;
        }
    }
}