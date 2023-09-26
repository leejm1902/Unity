using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Create : MonoBehaviour
{
    public Transform [] createPosition;
    public GameObject [] prefab;

    public void CreateUnit(int index)
    {
        Instantiate(prefab[index], createPosition[index].position, prefab[index].transform.rotation);      
    }

    
}
