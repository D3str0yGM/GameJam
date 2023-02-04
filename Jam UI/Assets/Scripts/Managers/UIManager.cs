using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [Header("PANELS")]
    [SerializeField] Text QualityLevelText;
    [SerializeField] Slider sliderVolume;

    // ******************** PANELS ***********************
    [SerializeField] GameObject PausePanel;
    [SerializeField] GameObject PauseMenu;
    Image PausePanelImage;

    [SerializeField] GameObject SettingsPanel;
    [SerializeField] GameObject SettingsMenu;
    [Header("Collected Items Settings")]
    [SerializeField] List<GameObject> holders;
    [SerializeField] List<Sprite> sprites;
    public int holder = 0;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            //Destroy(this);
        }
    }
    private void Start()
    {
        //PausePanelImage = PausePanel.GetComponent<Image>();
    }
    public void OpenPauseMenu()
    {
        PausePanel.SetActive(true);
        DOTween.To(() => PausePanelImage.color, x => PausePanelImage.color = x, new Color32(255, 255, 255, 233), 0.2f);
        PausePanel.transform.GetChild(0).transform.DOScale(1f, 0.15f);
    }

    public void Resume()
    {
        DOTween.To(() => PausePanelImage.color, x => PausePanelImage.color = x, new Color32(255, 255, 255, 0), 0.2f);
        PausePanel.transform.GetChild(0).transform.DOScale(0f, 0.15f).OnComplete(() =>
        {
            PausePanel.SetActive(false);
        });
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    private void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Escape))
        // {
        //     OpenPauseMenu();
        // }
    }
    public void IncreaseQuality()
    {
        QualitySettings.IncreaseLevel();
        UpdateQualityLabel();
    }
    public void DecreaseQuality()
    {
        QualitySettings.DecreaseLevel();
        UpdateQualityLabel();
    }
    private void UpdateQualityLabel()
    {
        int currentQuality = QualitySettings.GetQualityLevel();
        string qualityName = QualitySettings.names[currentQuality];
        QualityLevelText.text = "Quality Level - " + qualityName;
    }
    public void SliderVolume()
    {
        AudioListener.volume = sliderVolume.value;
    }

    public void CollectItem(string objectName)
    {
        foreach (Sprite spriteItem in sprites)
        {
            if (spriteItem.name == objectName)
            {
                holders[holder].GetComponent<Image>().sprite = spriteItem;
                holders[holder].gameObject.tag = "Use "+ objectName;
                holder++;
            }
        }
    }
    public void UseItem(string objectName)
    {
        holders.Remove(GameObject.FindGameObjectWithTag(objectName));
        Destroy(GameObject.FindGameObjectWithTag(objectName));
        holder--;
    }
}


