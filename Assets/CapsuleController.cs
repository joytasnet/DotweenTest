using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.DOColor(Color.blue,2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
