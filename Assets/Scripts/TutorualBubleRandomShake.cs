using UnityEngine;

public class TutorualBubleRandomShake : MonoBehaviour
{
    public float shakeMagnitude = 0.1f;

    private Vector3 originalPosition;
    
    private float randomOffsetX;
    private float randomOffsetY;

    private void Start()
    {
        originalPosition = transform.localPosition;
        randomOffsetX = Random.Range(0f, 360f);
        randomOffsetY = Random.Range(0f, 360f);
    }

    private void Update()
    {
        var shakeOffsetX = Mathf.Sin(Time.time + randomOffsetX) * shakeMagnitude;
        var shakeOffsetY = Mathf.Cos(Time.time + randomOffsetY) * shakeMagnitude;

        transform.localPosition = originalPosition + new Vector3(shakeOffsetX, shakeOffsetY, 0);
    }
}