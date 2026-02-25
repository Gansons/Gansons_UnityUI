using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class OutfitChanger : MonoBehaviour
{
    [System.Serializable]
    public class SpriteOption
    {
        public Image targetImage;      // Kur sprite tiek ielikts (Head (Image), Torso (Image), utt.)
        public Transform targetObject; // Īstais objekts layeringam (Head, Torso, Left arm, utt.)
        public Sprite sprite;          // Sprite attēls
        public Vector2 offset;         // Pozīcijas nobīde
        public float scale = 1f;       // Izmērs
        public int zIndex;             // Layering starp ķermeņa daļām
    }

    public List<SpriteOption> options;
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

        // Sprite maiņa
        opt.targetImage.sprite = opt.sprite;

        // Pozīcija
        opt.targetImage.rectTransform.anchoredPosition = opt.offset;

        // Scale
        opt.targetImage.rectTransform.localScale = new Vector3(opt.scale, opt.scale, 1f);

        // Z-index (GALVENAIS LABOJUMS)
        // Šeit mēs mainām sibling index PAREIZAJAM objektam:
        // Character → Head
        // Character → Torso
        // Character → Left arm
        // utt.
        opt.targetObject.SetSiblingIndex(opt.zIndex);
    }
}