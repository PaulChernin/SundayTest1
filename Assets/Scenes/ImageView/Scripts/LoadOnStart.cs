using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnStart : MonoBehaviour
{
    void Start()
    {
        var FetchImage = GetComponent<FetchImage>();

        FetchImage.imageUrl = ImageToShow.Url;
        FetchImage.StartFetching();
    }
}
