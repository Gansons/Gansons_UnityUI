using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    [Header("Characters")]
    public GameObject bandit;
    public GameObject knight;

    [Header("Player Custom Objects")]
    public GameObject banditCustom;
    public GameObject knightCustom;

    void Start()
    {
        SelectCharacter(1); // Knight pirmais
    }

    public void SelectCharacter(int index)
    {
        bool isBandit = index == 0;
        bool isKnight = index == 1;

        // Varoņi
        bandit.SetActive(isBandit);
        knight.SetActive(isKnight);

        // Katram savs PlayerCustom
        banditCustom.SetActive(isBandit);
        knightCustom.SetActive(isKnight);
    }
}