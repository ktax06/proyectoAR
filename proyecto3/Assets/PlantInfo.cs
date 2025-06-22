using UnityEngine;

public class PlantInfo : MonoBehaviour
{
    public string plantName;
    [TextArea] public string description;

    void OnMouseDown()
    {
        InfoPanel.Instance.Show(plantName, description);
    }
}
