using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    //[SerializeField] public GameObject enable;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hero"))
        {
            collision.GetComponent<WhenDied>().Died();
            Destroy(gameObject);
            //Triggers();
        }
    }
    //public void Triggers()
    //{
    //        gameObject.SetActive(true);
    //}
}
