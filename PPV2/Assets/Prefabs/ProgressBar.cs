using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
  [Header("PROGRESS BAR ATTRIBUTES")]
  public int maximum;
  public int current;
  public Image mask;
  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    GetCurrentFill();
  }

  public void GetCurrentFill()
  {
    float fillAmount = (float)current / (float)maximum;
    mask.fillAmount = fillAmount;
  }
}
