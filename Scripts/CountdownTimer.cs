using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // E�er UI'de g�stereceksen

public class CountdownTimer : MonoBehaviour
{
    public float totalTime = 240f; // 4 dakika = 240 saniye
    private float currentTime;

    public TextMeshProUGUI timerText; // UI Text ��esi atanmal� (iste�e ba�l�),

    public GameObject panel;

    public GameObject LosePanel;

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        if (panel.activeInHierarchy)
        {
            if (currentTime > 0)
            {
                currentTime -= Time.deltaTime;

                int minutes = Mathf.FloorToInt(currentTime / 60f);
                int seconds = Mathf.FloorToInt(currentTime % 60f);

                string timeFormatted = string.Format("{0:00}:{1:00}", minutes, seconds);

                if (timerText != null)
                    timerText.text = timeFormatted; // UI'de g�ster
                else
                    Debug.Log(timeFormatted); // Konsola yaz
            }
            else
            {
                LosePanel.SetActive(true);
                Time.timeScale = 0f;
                currentTime = 0;
            }
        }
    }

    public void TekrarOyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
