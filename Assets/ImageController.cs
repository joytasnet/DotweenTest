using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        //image.DOColor(new Color(1f,0,0),1.5f);
        image.DOFade(0f,1.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
