using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class Ref_LifeUI2 : MonoBehaviour
{
    [SerializeField] UIDocument document;

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

    ProgressBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        var root = document.rootVisualElement;

        Button cureButton = root.Query<Button>("cure");
        Button hitButton = root.Query<Button>("hit");
        healthBar = root.Query<ProgressBar>("lifebar");

        cureButton.clicked += Cure;
        hitButton.clicked += Hit;

        healthBar.value = life;
    }

    void Cure()
    {
        Life += 10;
        healthBar.value = life;
    }

    void Hit()
    {
        Life -= 10;
        healthBar.value = life;
    }
}
