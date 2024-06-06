using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimatedDash : MonoBehaviour
{
    LineRenderer LR;
    float iteration = 0;

    Coroutine Move;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        LR = GetComponent<LineRenderer>();
        StartCoroutine(Animate());
    }

    IEnumerator Animate()
    {
        while (true)
        {
            iteration += Speed * Time.deltaTime;
            LR.material.SetTextureOffset("_MainTex", new Vector2(iteration, 0));
            yield return null;
        }
    }


}
