using UnityEngine;
using TMPro;
using System;

public class NameAge : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField yearInput;
    public TMP_Text outputText;

    public void ShowResult()
    {
        string name = nameInput.text;
        string yearText = yearInput.text;

        // Vārda pārbaude
        if (string.IsNullOrWhiteSpace(name))
        {
            outputText.text = "Ievadi vārdu!";
            return;
        }

        // Gadam jābūt 4 cipariem
        if (yearText.Length != 4)
        {
            outputText.text = "Ievadi 4 ciparu dzimšanas gadu!";
            return;
        }

        // Pārbauda vai ir skaitlis
        if (!int.TryParse(yearText, out int birthYear))
        {
            outputText.text = "Nederīgs gads!";
            return;
        }

        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        // Drošības pārbaude
        if (age < 0 || age > 120)
        {
            outputText.text = "Nederīgs vecums!";
            return;
        }

        // Gala teksts
        outputText.text = $"{name}, {age} gadus vecs ir varonis.";
    }
}