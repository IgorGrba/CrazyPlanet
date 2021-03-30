using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
		{
            GameManager.instance.Restart();
        }

        GetComponent<RectTransform>().localScale = Vector3.one * Planet.Size;
    }
}
