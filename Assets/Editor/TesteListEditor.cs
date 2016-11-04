using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

[CustomEditor(typeof(TesteList))]
public class TesteListEditor : Editor {
	
	// Implement this function to make a custom
	// inspector.
	public override void OnInspectorGUI () {
        base.OnInspectorGUI();
	}
	
	// This function is called when the object
	// is loaded.
	void OnEnable () {
		
	}
	
}
