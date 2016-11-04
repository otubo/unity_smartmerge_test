using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

[CustomEditor(typeof(TesteArray))]
public class TesteArrayEditor : Editor {
    TesteArray script;



    // Implement this function to make a custom
    // inspector.
    public override void OnInspectorGUI () {
        GUILayout.Label("Array");
        GUILayout.Space(10);
        for (int y = 0; y < 10; y++)
        {
            GUILayout.BeginHorizontal();
            for (int x = 0; x < 10; x++)
            {
                string text = "";
                if (script.Info[x, y] == 1) text = "X";
                if(GUILayout.Button(text,GUILayout.Width(18)))
                {
                    script.Info[x, y] = 1 - script.Info[x, y];
                }
            }
            GUILayout.EndHorizontal();
        }
        GUILayout.Space(10);



    }
	



	// This function is called when the object
	// is loaded.
	void OnEnable () {
        script = (TesteArray)target;

    }
	
}
