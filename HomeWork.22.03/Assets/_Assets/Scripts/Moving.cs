using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class Moving : MonoBehaviour
{
    
    // Start is called before the first frame update
    [SerializeField] private Rigidbody2D rig2D;
    [SerializeField] private float move1 = 10.0f;
    public Vector2 startPoint;
    [SerializeField] private float distanceMoved = 0f;
    [SerializeField] private float maxDistance = 20f;
    [SerializeField] private bool isMoving = true;
    [SerializeField] private float speedMove = 1.0f;
    [SerializeField] private GameObject enable;
    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();
        startPoint = transform.position;
    }

    // Update is called once per frame
    public void Update()
    {
        if (isMoving)
        {
            move1 += speedMove * Time.deltaTime;
            Vector2 movement = Vector2.right * move1 * Time.deltaTime;
            rig2D.MovePosition(rig2D.position + movement);
            distanceMoved += movement.magnitude;
            if (distanceMoved >= maxDistance)
            {
                isMoving = false;
                Triggers();
            }
        }
    }
    void Triggers()
    {
        if(enable.activeInHierarchy == false)
        {
            enable.SetActive(true);
        }
    }
}
