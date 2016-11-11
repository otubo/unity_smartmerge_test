using UnityEngine;
using System.Collections;


[System.Serializable]
public class ArrayLine
{
    public int[] line = new int[10];
}


public class TesteArray : MonoBehaviour {
    public ArrayLine[] Info = new ArrayLine[10];
}
