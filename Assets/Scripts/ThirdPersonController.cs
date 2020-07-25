using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    [SerializeField] private Transform m_camera = null;
    [SerializeField] private float m_speed = 1;
    void Awake() {
        m_camera = Camera.main.gameObject.transform;
    }
    void Update() {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0,Input.GetAxis("Vertical"));
        movement = movement * m_speed * Time.deltaTime;
        movement = Quaternion.Euler(0, m_camera.localEulerAngles.y, 0) * movement;
        transform.position = transform.position + movement;

        Vector3 rotation = transform.eulerAngles;
        rotation.y = m_camera.eulerAngles.y;
        transform.eulerAngles = rotation;

        if(transform.position.y < -1) {
            transform.position = new Vector3(0, 1, 0);
        }
    }
}
