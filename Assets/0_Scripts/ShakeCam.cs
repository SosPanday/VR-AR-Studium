using System.Collections;
using UnityEngine;

public class ShakeCam : MonoBehaviour
{
    // Shake parameters
    public float shakeDuration = 1.0f;
    public float shakeMagnitude = 0.1f;
    public float shakeDelay = 4.0f;
    public float timeDelay = 0f;

    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.localPosition;
        if(!StaircaseGenerator.shake)
        {
            enabled = false;
        }
    }

    private void Update()
    {
        if(timeDelay <= 0.2f)
        {
            Shake();
        }
    }

    public void Shake()
    {
        StartCoroutine(ShakeCoroutine());
        timeDelay = shakeDelay;
    }

    private IEnumerator ShakeCoroutine()
    {
        float elapsed = 0.0f;

        while (elapsed < shakeDuration)
        {
            // Generate random shake offset
            float offsetX = Random.Range(-1.1f, 1.1f) * shakeMagnitude;
            float offsetY = Random.Range(-.12f, .12f) * shakeMagnitude;

            // Apply shake offset to the camera position
            transform.localPosition = originalPosition + new Vector3(offsetX, offsetY, 0);

            // Increment elapsed time
            elapsed += Time.deltaTime;
            yield return null;
        }

        // Reset the camera position after shake duration
        transform.localPosition = originalPosition;
        yield return new WaitForSeconds(4);
        timeDelay = 0f;
    }
}