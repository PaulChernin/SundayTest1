using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    public float time = 3.0f;
    private float value = 0.0f;

    public Transform textTransform;
    private TextMeshProUGUI text;
    private Slider slider;

    void Start()
    {
        text = textTransform.gameObject.GetComponent<TextMeshProUGUI>();
        slider = GetComponent<Slider>();

        value = 0.0f;
        slider.value = value;
    }

    void Update()
    {
        if (value < 1.0f)
        {
            value += Time.deltaTime * (1.0f / time);

            text.text = Mathf.Floor(value * 100.0f) + "%";
            slider.value = value;
        } else
        {
            SceneManager.LoadScene("Gallery", LoadSceneMode.Single);
        }
    }
}
