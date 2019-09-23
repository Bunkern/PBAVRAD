using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text text;
    public Text hudText;
    public Text addText;

    public GameObject colaPlayer;
    public GameObject mostPlayer;
    public GameObject awardPlayer;
    public GameObject colaRender;
    public GameObject mostRender;
    public GameObject awardRender;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        colaPlayer.SetActive(false);
        mostPlayer.SetActive(false);
        awardPlayer.SetActive(false);
        colaRender.SetActive(false);
        mostRender.SetActive(false);
        awardRender.SetActive(false);
        StartCoroutine(WaitAndPick());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Score()
    {
        score++;
        addText.text = "You have found " + score + " ads";
        if (score <= 2)
        {
            hudText.text = "Great - Now find the next one";
        }
        if (score == 3)
        {
            hudText.text = "Nice you found them all";
        }
    }

    IEnumerator WaitAndPick()
    {
        yield return new WaitForSeconds(5);
        text.text = "See if you can find a Cola Can";

        yield return new WaitForSeconds(2);
        text.text = "Ohh Look a Butterfly...";

        yield return new WaitForSeconds(5);
        text.text = "Ohh Yeah - when you find one you need to touch it";
    }
}
