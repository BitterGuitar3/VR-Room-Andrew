using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticalRotate : MonoBehaviour
{
    [SerializeField] float roateSpeed;
    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, roateSpeed * Time.deltaTime, 0);
        transform.Rotate(0, roateSpeed * Time.deltaTime, 0);
    }
}
