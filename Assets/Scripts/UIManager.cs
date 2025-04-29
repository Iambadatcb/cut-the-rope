using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Image[] starPicBoxes;
    public Sprite filledStar;

    private int index = 0;

    private void Awake()
    {
        if(instance == null) instance = this;
        else gameObject.SetActive(false);//if more than one, deactivate
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextStar()
    {
        starPicBoxes[index++].sprite = filledStar;
    }
}
