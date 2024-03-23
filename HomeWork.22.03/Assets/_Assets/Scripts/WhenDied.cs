using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenDied : MonoBehaviour
{
    [SerializeField] public GameObject enable;
    [SerializeField] public GameObject enaBle;
    public void Died()
    {
        gameObject.SetActive(false);
        Triggers();
        gameObject.SetActive(false);
        //StartCoroutine(ShowDeathEffect());  
        Triggers();
        Enable();
    }
    public void Triggers()
    {
        if(enable.activeInHierarchy == false)
        {
            enable.SetActive(true);
        }
    }
    public void Enable()
    {
        if (enaBle.activeInHierarchy == false)
        {
            enaBle.SetActive(true);
        }
    }
}
