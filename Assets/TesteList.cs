using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class ListInfo
{
    public string Name;
    public int Id;
}

public class TesteList : MonoBehaviour {

    public List<ListInfo> List = new List<ListInfo>();
}
