using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    private Node[] nodePath;

    // Start is called before the first frame update
    void Start()
    {
        nodePath = GetComponentsInChildren<Node>();
    }

    public Node[] GetPath()
    {
        return nodePath;
    }
}
