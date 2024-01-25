using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test" + moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
