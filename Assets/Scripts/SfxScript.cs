using UnityEngine;
using UnityEngine.UI;

public class SfxScript : MonoBehaviour
{
    [Header("Audio Settings")]
    public AudioSource audioSource;
    public AudioClip soundEffect;

    [Header("UI Button (optional)")]
    public Button button;

    private void Start()
    {
        // Ja skripts ir piesaistīts UI pogai, piesaistām klikšķa eventu
        if (button != null)
        {
            button.onClick.AddListener(PlaySfx);
        }
    }

    public void PlaySfx()
    {
        if (audioSource != null && soundEffect != null)
        {
            audioSource.PlayOneShot(soundEffect);
        }
        else
        {
            Debug.LogWarning("AudioSource vai SoundEffect nav pievienots!");
        }
    }
}