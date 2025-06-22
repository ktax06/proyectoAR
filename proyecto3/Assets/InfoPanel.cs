using UnityEngine;
using TMPro;

public class InfoPanel : MonoBehaviour
{
    public static InfoPanel Instance;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    public GameObject panel;

    void Awake() => Instance = this;

    public void Show(string name, string desc)
    {
        titleText.text = name;
        descriptionText.text = desc;
        panel.SetActive(true);
    }

    public void Hide()
    {
        panel.SetActive(false);
    }
}
