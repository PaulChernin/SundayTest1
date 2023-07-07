using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ViewImage : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        var fetchImage = GetComponent<FetchImage>();
        ImageToShow.Url = fetchImage.imageUrl;
        
        SceneManager.LoadScene("ImageView", LoadSceneMode.Single);
    }
}
