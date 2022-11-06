using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


 

public class StartupScript : MonoBehaviour
{
	
	public Vector2 newPos;
	

    // Start is called before the first frame update
    void Start()
	{
		Sequence mySequence = DOTween.Sequence();
		mySequence.Append(GetComponent<RectTransform>().DOAnchorPos(newPos ,  4).SetEase(Ease.InOutBounce));
		mySequence.PrependInterval(4);
		mySequence.Play();	 
	}
    
	public void Button()
	{
		DOTween.PauseAll();
		GetComponent<RectTransform>().DOAnchorPos(newPos ,  4).SetEase(Ease.InOutFlash);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
