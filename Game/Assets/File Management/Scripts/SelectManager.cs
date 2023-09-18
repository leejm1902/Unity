using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    [SerializeField] List<GameObject> units;

    public void SelectUnit(int select)
    {
        for(int i = 0; i<units.Count; i++)
        {
            if(select == i)
            {
                units[select].SetActive(true);
            }

            else
            {
                units[i].SetActive(false);
            }
        }
    }
}
