using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// https://www.youtube.com/watch?v=IspA7PTO6dM
// Скрипт вешаем на камеру
// камеру кладем в playtrBody
// playtrBody например: куб или капсула
//

public class CamMouseController : MonoBehaviour
{
    public float mouseSens = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
        
    }
}
