using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPresenter : MonoBehaviour
{
    [SerializeField] Level level;
    [SerializeField] Text displayText;
    [SerializeField] Text experienceText;
    [SerializeField] Button increaseXPButton;

    private void Start()
    {
        increaseXPButton.onClick.AddListener(RiseExperience);
        level.onGetExperience += UpdateUI;
        UpdateUI();
    }

    private void RiseExperience()
    {
        level.GainExperience(10);
    }

    private void UpdateUI()
    {
        displayText.text = $"Level: {level.GetLevel()}";
        experienceText.text = $"XP: {level.GetExperience()}";
    }
}
