using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public Transform cameraTarget; //cam'in takip edece�i obje
    public float sSpeed = 10f;
    public Vector3 dist;
    public Transform lookTarget; //cam'in takip s�ras�nda bakaca�� obje

    private void LateUpdate()
    {
        Vector3 dPos = cameraTarget.position + dist; //takip esnas�nda cameran�n hedefine g�re duraca�� pozisyon
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
        transform.position = sPos;
        transform.LookAt(lookTarget.position);
        
    }
}
