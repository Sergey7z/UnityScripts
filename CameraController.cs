using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 rot;
    public float speed = 5f;

    void Start(){
        Cursor.visible = false;
    }

    void Update(){
        
        rot.x = Input.mousePosition.x / speed;
        rot.y = Input.mousePosition.y / speed;
        transform.rotation = Quaternion.Euler(-rot.y, rot.x, 0);
 
    }
}
