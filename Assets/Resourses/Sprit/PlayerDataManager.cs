using System;
using UnityEngine;

public class PlayerDataManager : MonoBehaviour
{
    public const string PlayerPrefsKeySex = "PlayerSex";
    public const string PlayerPrefsKeyAge = "PlayerAge";
    public const string PlayerPrefsKeyClass = "PlayerClass";

    public void SaveSex(string sex)
    {
        PlayerPrefs.SetString(PlayerPrefsKeySex, sex);
        PlayerPrefs.Save();
    }

    public void SaveAge(string age)
    {
        PlayerPrefs.SetString(PlayerPrefsKeyAge, age);
        PlayerPrefs.Save();
    }

    public void SaveClass(String Class)
    {
        PlayerPrefs.SetString(PlayerPrefsKeyClass, Class);
        PlayerPrefs.Save();
    }

    public string LoadSex()
    {
        return PlayerPrefs.GetString(PlayerPrefsKeySex, "");
    }

    public string LoadAge()
    {
        return PlayerPrefs.GetString(PlayerPrefsKeyAge, "");
    }

    public string LoadClass()
    {
        return PlayerPrefs.GetString(PlayerPrefsKeyClass, "");
    }
}