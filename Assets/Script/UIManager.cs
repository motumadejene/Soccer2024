using UnityEngine;

public class UIManager : MonoBehaviour
{
    // References to the panels
    public GameObject mainMenuPanel;
    public GameObject profilePanel;
    public GameObject settingsPanel;
    public GameObject selectTeamPanel;
    public GameObject middlePanel;

    // Toggles the profile panel visibility
    public void ToggleProfilePanel()
    {
        profilePanel.SetActive(!profilePanel.activeSelf);
    }

    // Shows the settings panel and hides the middle panel
    public void ShowSettingsPanel()
    {
        settingsPanel.SetActive(true);
        middlePanel.SetActive(false);
    }

    // Hides the settings panel and shows the middle panel
    public void HideSettingsPanel()
    {
        settingsPanel.SetActive(false);
        middlePanel.SetActive(true);
    }

    // Shows the select team panel and hides the main menu panel
    public void ShowSelectTeamPanel()
    {
        mainMenuPanel.SetActive(false);
        selectTeamPanel.SetActive(true);
    }
}
