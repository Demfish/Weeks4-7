using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Size : MonoBehaviour
{
    //Declare public variables
      public Slider sizeSlider;

      public float sizeSliderNumber;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sizeSliderNumber = sizeSlider.value;
        Vector2 scale = new Vector2(sizeSliderNumber,sizeSliderNumber); //making the x and the y value increase with the slider
        this.transform.localScale = scale; //make scale equal the transforming of the ships scale

    }
}
