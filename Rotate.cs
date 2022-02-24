// Вращение объекта вокруг своего центра
// Rotation of an object around its center

using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
    float positionX, positionY, positionZ; // Позиция вращения
    public float rotationSpeed; // Скорость вращения
    public sbyte aroundX, aroundY, aroundZ; // Направление вращения
    
    void Update() {
        
        positionX = gameObject.transform.position.x; // Получение позиции вращения от объекта
        positionY = gameObject.transform.position.y; // к которому прикреплен скрипт,
        positionZ = gameObject.transform.position.z; // т.е. свои собственные координаты
    
        transform.RotateAround (new Vector3(positionX, positionY, positionZ),
                                new Vector3(aroundX, aroundY, aroundZ),
                                rotationSpeed * Time.deltaTime);

        // Это не обязательно, можно удалить
        if (aroundX > 1) aroundX = 1;
        if (aroundX < -1) aroundX = -1;
        if (aroundY > 1) aroundY = 1;
        if (aroundY < -1) aroundY = -1;
        if (aroundZ > 1) aroundZ = 1;
        if (aroundZ < -1) aroundZ = -1;
    }
}
