using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runningSpeed;
    float touchXDelta = 0;
    float newX = 0;
    public float xSpeed;
    public float limitx;

    void Start()
    {

    }


    void Update()
    {
        SwipeCheck();
    }


    void SwipeCheck()
    {
        // karaktere z ekseni y�n�nde(ileri do�ru) belirli bir h�zda hareket verdik 



        //cihaza dokununca sayan sayac
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)//dokundu�umuzda ve parma��
                                                                                //hareket ettirdi�imizde
        {
            //Debug.Log(Input.GetTouch(0).deltaPosition.x / Screen.width);//daha k���k de�erler almak i�in b�ld�k
            touchXDelta = Input.GetTouch(0).deltaPosition.x / Screen.width;

        }
        else if (Input.GetMouseButton(0))
        {
            touchXDelta = Input.GetAxis("Mouse X");
        }

        newX = transform.position.x + xSpeed * touchXDelta * Time.deltaTime;
        newX = Mathf.Clamp(newX, -limitx, limitx);

        Vector3 newPosition = new Vector3(newX, transform.position.y, transform.position.z + runningSpeed * Time.deltaTime);
        transform.position = newPosition;
    }
}
