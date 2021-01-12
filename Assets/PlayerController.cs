using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody m_Rb;

    private void Awake()
    {
        m_Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalIn = Input.GetAxis("Horizontal");
        float verticalIn = Input.GetAxis("Vertical");

        //float newHorizontalPos = transform.position.x + horizontalIn * speed * Time.deltaTime;
        //float newVerticalPos = transform.position.z + verticalIn * speed * Time.deltaTime;

        //// 1. Change Position
        //transform.position = new Vector3(
        //    newHorizontalPos,
        //    transform.position.y,
        //    newVerticalPos
        //);

        Vector3 movement = new Vector3(horizontalIn, 0, verticalIn);
        movement.Normalize();

        //transform.Translate(movement * Time.deltaTime * speed);

        m_Rb.MovePosition(m_Rb.position + movement * speed * Time.deltaTime);
    }
}
