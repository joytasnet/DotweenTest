using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.WSA;

public class PanelController : MonoBehaviour
{
    RectTransform rt;
    // Start is called before the first frame update
    void Start()
    {
        rt = GetComponent<RectTransform>();
        rt.DOAnchorPos(new Vector2(100f,0),0.6f)
        .SetEase(Ease.OutBack);
        rt.DOLocalRotate(new Vector3(360f,0,0),0.6f,RotateMode.FastBeyond360)
        .SetEase(Ease.OutCubic);
        rt.localScale=Vector3.one * 0.2f;
        rt.DOScale(1f,0.6f)
        .SetEase(Ease.OutBack,5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
