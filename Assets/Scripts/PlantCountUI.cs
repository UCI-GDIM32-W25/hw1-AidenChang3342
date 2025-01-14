using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;
    private void Start ()
    {
        _remainingText.SetText("5");
        _plantedText.SetText("0");
    }

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _remainingText.SetText("" + seedsLeft);
        _plantedText.SetText("" + seedsPlanted);
    }
}