using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Create : MonoBehaviour
{
    public Button button;
    public GameObject prefab;

    private bool active = true;
    private float currentTime = 5f;

    public void CreateGeneric()
    {
        active = false;

        Instantiate(prefab);
        // .AddComponent<Delete>()
    }

    void Update()
    {
        if(active == false)
        {
            button.interactable = false;
            currentTime -= Time.deltaTime;
            button.image.fillAmount = currentTime / 5f;

            if(currentTime <= 0)
            {
                active = true;
                button.interactable = true;
                button.image.fillAmount = currentTime = 5f;
            }
        }
    }
}