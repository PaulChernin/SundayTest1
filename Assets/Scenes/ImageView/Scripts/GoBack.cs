using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoBack : MonoBehaviour
{
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(GalleryScene);
    }

    public void GalleryScene()
    {
        SceneManager.LoadScene("Gallery", LoadSceneMode.Single);
    }
}
