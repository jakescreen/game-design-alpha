﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;

public class FinalScore : MonoBehaviour
{
    public Text score = null;
    public Text flavor = null, color = null, deco = null, size = null, shape = null, Layer = null;
	public Image background1;
	public Image background2;
	public Image background3;

    // Start is called before the first frame update
    void Start()
    {
        float points = (((float) clickButton.ans) / 8.0f) * 100.0f;
        System.Console.WriteLine(points);
        score.text = "total: " + points.ToString() + "%";
		
        onmenuselsct.customer += 1;
        if(onmenuselsct.customer > 3)
        {
            onmenuselsct.customer = 1;
        }
       

        

    }

    // Update is called once per frame
    void Update()
    {
        // this is jank
        if (onmenuselsct.customer == 1)
        {
            Layer.text = "3";
            flavor.text = "Vanilla";
            color.text = "Blue";
            deco.text = "Decorative Icing, Candles, Writing";
            size.text = "Medium";
            shape.text = "Rectangle";
        }
		else if (onmenuselsct.customer == 2)
        {
            Layer.text = "2";
            flavor.text = "Chocolate";
            color.text = "Purple";
            deco.text = "Sprinkles";
            size.text = "Large";
            shape.text = "Circle";
        } else if (onmenuselsct.customer == 3)
		{
			Layer.text = "3";
            flavor.text = "Red Velvet";
            color.text = "White";
            deco.text = "Decorative Icing, Writing";
            size.text = "Large";
            shape.text = "Rectangle";
		}


        if (clickButton.layersCorrect)
        {
            Layer.color = Color.green;
        }
        else
        {
            Layer.color = Color.red;
        }
        if (clickButton.icingCorrect)
        {
            color.color = Color.green;
        }
        else
        {
            color.color = Color.red;
        }
        if (clickButton.decorCorrect4)
        {
            deco.color = Color.green;
        }
        else
        {
            deco.color = Color.red;
        }
        if (clickButton.sizeCorrect)
        {
            size.color = Color.green;
        }
        else
        {
            size.color = Color.red;
        }
        if (clickButton.shapeCorrect)
        {
            shape.color = Color.green;
        }
        else
        {
            shape.color = Color.red;
        }
        if (clickButton.flavorCorrect)
        {
            flavor.color = Color.green;
        }
        else
        {
            flavor.color = Color.red;
        }
    }
}
