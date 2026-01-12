using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;
    [SerializeField] private Player player;


    private void Start()
    {
        _plantedText.text = player._numSeeds.ToString();
    }
    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _plantedText.text = seedsPlanted.ToString();
        _remainingText.text = seedsLeft.ToString();
    }
}