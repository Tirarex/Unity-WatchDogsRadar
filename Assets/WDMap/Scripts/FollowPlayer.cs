using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform PlayerPivot;
    void Start()
    {
        
    }

    Vector3 Rot;
    void Update()
    {
        this.transform.position = PlayerPivot.position;
        Rot = new Vector3(0, PlayerPivot.eulerAngles.y,0);
        this.transform.eulerAngles = Rot;
    }
}
