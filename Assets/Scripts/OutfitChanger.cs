using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class OutfitChanger : MonoBehaviour
{
    [System.Serializable]
    public class SpriteOption
    {
        public Sprite sprite;          // Sprite attēls
        public Vector2 offset;         // Manuāla pozīcijas nobīde (X/Y)
        public float scale = 1f;       // Manuāls izmērs
    }

    public Image bodypart;             // UI Image, kur mainās sprite
    public List<SpriteOption> options; // Visi varianti ar saviem offsetiem

    private int currentIndex = 0;

    public void NextOption()
    {
        if (options.Count == 0) return;

        currentIndex++;
        if (currentIndex >= options.Count)
            currentIndex = 0;

        ApplyOption();
    }

    public void PreviousOption()
    {
        if (options.Count == 0) return;

        currentIndex--;
        if (currentIndex < 0)
            currentIndex = options.Count - 1;

        ApplyOption();
    }

    private void ApplyOption()
    {
        SpriteOption opt = options[currentIndex];

        // Mainām sprite
        bodypart.sprite = opt.sprite;

        // Mainām pozīciju
        bodypart.rectTransform.anchoredPosition = opt.offset;

        // Mainām izmēru
        bodypart.rectTransform.localScale = new Vector3(opt.scale, opt.scale, 1f);
    }
}