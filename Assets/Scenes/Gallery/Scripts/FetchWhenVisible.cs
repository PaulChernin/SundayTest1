using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class FetchWhenVisible : MonoBehaviour
{    
    private FetchImage fetchImage;
    private RectTransform rectTransform;

    void Awake()
    {
        fetchImage = GetComponent<FetchImage>();
        rectTransform = GetComponent<RectTransform>();
    }

    private bool IsVisible()
    {
        float y = rectTransform.position.y;
        return y > 0 && y < Screen.height;
    }

    void Update()
    {
        if (!fetchImage.fetchingStarted && IsVisible())
        {
            fetchImage.StartFetching();
        }
    }
}
