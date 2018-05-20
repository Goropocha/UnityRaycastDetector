using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SampleRaycastDetector : MonoBehaviour {

  [SerializeField] private Button buttonWithImage;
  [SerializeField] private Button buttonNoImage;

  [SerializeField, Header("Output Panel")] private Text infoPanelText;

  // Use this for initialization
  void Start() {
    buttonWithImage.onClick.AddListener(() => {
      infoPanelText.text = "Button With Image!\n";
    });
    buttonNoImage.onClick.AddListener(() => {
      infoPanelText.text = "No Image Button!\n";
    });
  }
}