using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    [SerializeField] Slider hpBar;

    public void CurrentHP(float hp, float maxHP)
    {
        // Unit ü�� / Unit Max ü��
        hpBar.value = hp / maxHP;
    }
}
