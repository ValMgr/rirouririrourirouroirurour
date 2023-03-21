using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
  
  public static GameManager instance;
  public static GameManager getInstance(){
    return instance;
  }

  private GameManager(){
    if (instance == null) {
      instance = this;
    } else {
      Destroy(gameObject);
    }
  }

  private void Awake() {
    DontDestroyOnLoad(gameObject);
  }

  private void Start() {
    LoadScene("Intialization");
  }

  public void LoadScene(string sceneName){
    SceneManager.LoadScene(sceneName);
  }
}