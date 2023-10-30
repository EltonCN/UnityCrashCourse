using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LifeUI : MonoBehaviour
{
    [SerializeField] Image lifeBar;
    [SerializeField] FloatVariable life;

    void Update()
    {
        lifeBar.fillAmount = Life/100;
    }
    
    float Life
    {
        get
        {
            return life.value;
        }
        set
        {
            if(value < 0)
            {
                value = 0;
            }
            else if (value > 100)
            {
                value = 100;
            }
            life.value = value;
        }
    }

}
