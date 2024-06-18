using UnityEngine;
using UnityEngine.UI;

public class ToggleGroups : MonoBehaviour
{
    public Button toggleButton;
    public GameObject[] firstGroup;
    public GameObject[] secondGroup;

    void Start()
    {
        if (toggleButton != null)
        {
            toggleButton.onClick.AddListener(OnToggleButtonClicked);
        }
    }

    void OnToggleButtonClicked()
    {
        SetActiveGroup(firstGroup, false);
        SetActiveGroup(secondGroup, true);
    }

    void SetActiveGroup(GameObject[] group, bool isActive)
    {
        foreach (GameObject obj in group)
        {
            if (obj != null)
            {
                obj.SetActive(isActive);
            }
        }
    }
}

