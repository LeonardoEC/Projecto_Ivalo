using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movimientos : MonoBehaviour
{
    public float velocidad = 5f;

    public float m_horizontal;
    public float m_vertical;

    void Start()
    {
        
    }


    void Update()
    {
        m_horizontal = Input.GetAxis("Horizontal");
        m_vertical = Input.GetAxis("Vertical");
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);

    }

    private void FixedUpdate()
    {
        movimiento();
    }

    public void movimiento()
    {
        Vector3 movimiento = new Vector3(m_horizontal, 0f, m_vertical) * velocidad * Time.deltaTime;
        transform.Translate(movimiento, Space.World);
        

    }
}
