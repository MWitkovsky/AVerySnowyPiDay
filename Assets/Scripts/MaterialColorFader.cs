using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColorFader : MonoBehaviour {

    [SerializeField] private Color color1, color2;
    [SerializeField] private float lerpSpeed;

    private SpriteRenderer rend;
    private Color currentColor;
    private bool toColor2;

	void Start () {
        rend = GetComponent<SpriteRenderer>();
        currentColor = color1;
        rend.color = currentColor;
        toColor2 = true;
	}
	
	void Update () {
        if (toColor2)
        {
            currentColor = Color.Lerp(currentColor, color2, lerpSpeed * Time.deltaTime);
            if(Mathf.Abs(currentColor.r - color2.r) < 0.05f)
            {
                toColor2 = false;
            }
        }
        else
        {
            currentColor = Color.Lerp(currentColor, color1, lerpSpeed * Time.deltaTime);
            if (Mathf.Abs(currentColor.r - color1.r) < 0.05f)
            {
                toColor2 = true;
            }
        }
        rend.color = currentColor;
    }
}
