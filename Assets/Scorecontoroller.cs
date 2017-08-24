using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorecontoroller : MonoBehaviour {
    int score = 0;
     public GameObject scoreText;

  

    // Use this for initialization
    public void Addscore() {
        this.score += 10;
  
        
	}

     void Start()
    {
        this.scoreText = GameObject.Find("Canvas/Text");
    }
    // Update is called once per frame
    void Update () {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
       // Debug.Log(scoreText);
	}
}
