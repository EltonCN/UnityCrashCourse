using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ref_LifeUI : MonoBehaviour
{
    [SerializeField] Image lifeBar;

    float life = 50;

    float Life
    {
        get
        {
            return life;
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
            life = value;
        }
    }


    public void Cure()
    {
        Life += 10;
        
        lifeBar.fillAmount = Life/100;
    }

    public void Hit()
    {
        Life -= 10;
        
        lifeBar.fillAmount = Life/100;
    }
}
