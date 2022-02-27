using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 rot;
    public float speedMove = 5f;
    public float speedRotX = 0f,
                 speedRotY = 0f;

    void Start(){
        Cursor.visible = false;
        
    }

    void Update(){
        if (speedRotX > 0){
            rot.x = Input.mousePosition.x * speedRotX;
        }
        if (speedRotY > 0){
            rot.y = Input.mousePosition.y * -speedRotY;
        }
        if (speedRotX < 0){
            rot.x = Input.mousePosition.x / -speedRotX;
        }
        if (speedRotY < 0){
            rot.y = Input.mousePosition.y / speedRotY;
        }
        
        transform.rotation = Quaternion.Euler (rot.y, rot.x, 0);
        
        if(Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0, 0, speedMove * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.position -= new Vector3(0, 0, speedMove * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.position -= new Vector3(speedMove * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(speedMove * Time.deltaTime, 0, 0);
        }
        

 
    }
}
