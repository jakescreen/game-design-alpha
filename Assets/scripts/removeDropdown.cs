﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class removeDropdown : MonoBehaviour
{
    // Start is called before the first frame update
    Dropdown drop = null;

    public void Removed(Dropdown drop)
    {
        int val = drop.value;
        drop.options.RemoveAt(val);
    }
  

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}