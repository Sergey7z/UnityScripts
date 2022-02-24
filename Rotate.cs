// Вращение объекта вокруг своего центра
// Rotation of an object around its center

using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
    float positionX, positionY, positionZ;
    public float rotationSpeed;
    public sbyte aroundX, aroundY, aroundZ;
    
    void Update() {
        
        positionX = gameObject.transform.position.x;
        positionY = gameObject.transform.position.y;
        positionZ = gameObject.transform.position.z;
    
        transform.RotateAround (new Vector3(positionX, positionY, positionZ),
                                new Vector3(aroundX, aroundY, aroundZ),
                                rotationSpeed * Time.deltaTime);

        if (aroundX > 1) aroundX = 1;
        if (aroundX < -1) aroundX = -1;
        if (aroundY > 1) aroundY = 1;
        if (aroundY < -1) aroundY = -1;
        if (aroundZ > 1) aroundZ = 1;
        if (aroundZ < -1) aroundZ = -1;
    }
}
