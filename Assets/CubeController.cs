using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class CubeController : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        /*
        transform.DOLocalMove(new Vector3(10f,0,0),1f)
        .SetEase(Ease.InBounce);
        */
        //transform.DOLocalRotate(new Vector3(0f,360f,-0f),1f,RotateMode.FastBeyond360);
        //transform.DOLookAt(target.position,2f);
        /*
        transform.DOLocalMove(target.position,1f)
        .SetDelay(2f)
        .SetLoops(3,LoopType.Incremental)
        .SetEase(Ease.InOutQuart)
        .OnComplete(MyCompleteFunction);
        */
        StartCoroutine(MyMove());
    }

    void MyCompleteFunction(){
        Destroy(target.gameObject);

    }
    IEnumerator MyMove(){
        transform.DOLocalMove(target.position,4f);
        yield return new WaitForSeconds(1f);
        transform.DOComplete();
    }

}
