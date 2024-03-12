using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    // Start is called before the first frame update

    public Text ZombiesWin;
    public Text SurvivorWins;

    public void GameOver(int winner)
    {
        gameObject.SetActive(true);
        if(winner == 0)
        {
            ZombiesWin.gameObject.SetActive(true);
        }
        else
        {
            SurvivorWins.gameObject.SetActive(true);
        }
    }

    public void PlayAgainButton()
    {
        Debug.Log("Run it back");
        SceneManager.LoadScene("Gameplay");
    }

    public void CharacterSelectButton()
    {
        SceneManager.LoadScene("Character Select");
    }

    public void QuitButton()
    {
        Debug.Log("Bye!");
        Application.Quit();
    }
}
