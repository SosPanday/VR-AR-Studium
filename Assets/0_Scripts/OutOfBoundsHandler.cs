using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OutOfBoundsHandler : MonoBehaviour
{
    [Header("Scene")]
    public string scenename;
    public Image blackScreen;
    public float fadeDuration = 1.5f;

    private void Start()
    {
        try
        {
            blackScreen = Camera.main.GetComponentInChildren<Image>();
        } catch {
            Debug.Log("No image found");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check for player
        if (other.CompareTag("Player"))
        {
            FadeHandler();
        }
    }

    void FadeHandler()
    {
        StartCoroutine(FadeCoroutine());
    }

    IEnumerator FadeCoroutine()
    {
        float elapsedTime = 0f;
        Color startColor = blackScreen.GetComponent<Image>().color;
        Color targetColor = new Color(startColor.r, startColor.g, startColor.b, 1f);

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            blackScreen.color = Color.Lerp(startColor, targetColor, elapsedTime / fadeDuration);
            yield return null;
        }

        blackScreen.color = targetColor; // Ensure it's fully black at the end

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(scenename);
    }
}
