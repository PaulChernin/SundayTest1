using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(LoadingScene);
    }

    public void LoadingScene()
    {
        SceneManager.LoadScene("Loading", LoadSceneMode.Single);
    }
}
