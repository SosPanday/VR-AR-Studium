using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScene : MonoBehaviour
{

    public string scenename;

    private float swapTimer = -50;

    public void SwapScenes()
    {
        swapTimer = 1.5f;
        try
        {
            Camera.main.GetComponents<FadeCamera>()[0].enabled = false;
            Camera.main.GetComponents<FadeCamera>()[1].enabled = true;
            Camera.main.GetComponents<FadeCamera>()[1].Reset();
        }
        catch
        { }
    }

    void Update()
    {
        if(swapTimer > -10)
        {
            swapTimer -= Time.deltaTime;
            if(swapTimer < 0)
            {
                SceneManager.LoadScene(scenename);
            }

        }
    }
}
