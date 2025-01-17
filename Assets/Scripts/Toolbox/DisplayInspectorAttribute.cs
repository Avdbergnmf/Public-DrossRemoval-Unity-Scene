﻿using UnityEngine;

/// <summary>
/// Use to display inspector of property object
/// </summary>
public class DisplayInspectorAttribute : PropertyAttribute
{
    public readonly bool DisplayScript;

    public DisplayInspectorAttribute(bool displayScriptField = true)
    {
        DisplayScript = displayScriptField;
    }
}
