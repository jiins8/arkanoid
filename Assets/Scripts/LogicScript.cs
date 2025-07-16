using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
 public int lifes, playerScore;
 public Text lifesText, scoreText;
[ContextMenu("Increase Score")]
 public void addScore(){
    playerScore = playerScore + 10;
    scoreText.text = "Score: " + playerScore.ToString();
 }
[ContextMenu("Take life")]
 public void takeLife(){
    lifes = lifes - 1;
    lifesText.text = "Lifes left: " + lifes;
 }
}
