using UnityEngine;
using UnityEngine.UI;

public class CategoryToggle : MonoBehaviour
{
    public Toggle swordsToggle;
    public Toggle shieldsToggle;

    public GameObject swordsParent;
    public GameObject shieldsParent;

    private void Start()
    {
        swordsToggle.onValueChanged.AddListener(OnSwords);
        shieldsToggle.onValueChanged.AddListener(OnShields);

        // Start with swords ON (or whichever you want)
        swordsToggle.isOn = true;
        shieldsToggle.isOn = false;

        swordsParent.SetActive(true);
        shieldsParent.SetActive(false);
    }

    private void OnSwords(bool on)
    {
        if (!on) return;

        swordsParent.SetActive(true);
        shieldsParent.SetActive(false);
    }

    private void OnShields(bool on)
    {
        if (!on) return;

        shieldsParent.SetActive(true);
        swordsParent.SetActive(false);
    }
}