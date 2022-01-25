using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform camTr, tr;

    void Start()
    {
        camTr = Camera.main.GetComponent<Transform>();
        tr = GetComponent<Transform>();
    }

    void LateUpdate()
    {
        tr.LookAt(camTr.position);
    }
}
