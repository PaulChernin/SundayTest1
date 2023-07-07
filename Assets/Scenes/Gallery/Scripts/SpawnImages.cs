using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnImages : MonoBehaviour
{
    public Transform Image;
    public int imagesCount = 2;

    void Start()
    {
        for (int i = 1; i <= imagesCount; i++)
        {
            Transform newImage = Instantiate(Image, transform);

            var fetchImage = newImage.GetComponent<FetchImage>();
            fetchImage.imageUrl = $"https://data.ikppbb.com/test-task-unity-data/pics/{i}.jpg";
        }
    }
}
