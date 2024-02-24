using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CheckNewVersion : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(CheckVersion());
    }

    IEnumerator CheckVersion()
    {
        UnityWebRequest www = UnityWebRequest.Get("https://raw.githubusercontent.com/Shannja/MonkeTag/master/VERSION");
        yield return www.SendWebRequest();
        string onlineVersion = www.downloadHandler.text;

        Debug.Log(onlineVersion);
    }
}
