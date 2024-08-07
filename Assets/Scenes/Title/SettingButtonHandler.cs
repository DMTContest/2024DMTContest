using UnityEngine;
using UnityEngine.UI;

public class SettingButtonHandler : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        if(Panel != null)
        {
            AudioManager.Instance.PlaySFX("Click");
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }
    }
}