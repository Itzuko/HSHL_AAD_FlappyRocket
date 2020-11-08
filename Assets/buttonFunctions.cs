using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonFunctions : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
