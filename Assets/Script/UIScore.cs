using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore: MonoBehaviour {
  // Start is called before the first frame update
  public Text highScore;
  public Text currentScore;

  void Start() {

  }

  // Update is called once per frame
  private void Update() {
    highScore.text = ScoreManager.Instance.HighScore.ToString();
    currentScore.text = ScoreManager.Instance.CurrentScore.ToString();
  }
  public void Show() {
    gameObject.SetActive(true);
  }
  public void Hide() {
    gameObject.SetActive(false);
  }
}
