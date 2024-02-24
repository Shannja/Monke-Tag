using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CheckNewVersion : MonoBehaviour
{
    string appVersion = "0.0.1";
    private void Awake()
    {
        StartCoroutine(CheckVersion());
    }

    IEnumerator CheckVersion()
    {
        UnityWebRequest www = UnityWebRequest.Get("https://raw.githubusercontent.com/Shannja/Monke-Tag/master/VERSION");
        yield return www.SendWebRequest();
        string onlineVersion = www.downloadHandler.text;
        Debug.Log(onlineVersion);

        if (onlineVersion.CompareTo(appVersion) > 0)
        {
            Application.OpenURL("https://github.com/Shannja/Monke-Tag/releases");
        }
    }
}
