using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _settingsButton;

    [SerializeField] private Progress _progress;
    [SerializeField] private TextMeshProUGUI _scoreText;

    private void Start()
    {
        //_scoreText.text = _progress.MaxScore.ToString();
        _playButton.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    

}
