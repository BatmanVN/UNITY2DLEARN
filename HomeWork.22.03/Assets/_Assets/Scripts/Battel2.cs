using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battel2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody2D bullet;
    [SerializeField] private int speedAttk;
    void Start()
    {
        speedAttk = Random.Range(3, 10);
    }

    // Update is called once per frame
    void Update()
    {
        bullet.velocity = Vector3.left * speedAttk * Time.deltaTime*100;
        Debug.Log(speedAttk);
    }
}
