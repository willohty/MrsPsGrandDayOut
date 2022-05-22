using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VersionReader : MonoBehaviour
{
    public string returnBuild()
    {
        string path = "Assets/TextFiles/Version.txt";
        string[] lines = System.IO.File.ReadAllLines (path);
        string build = lines[0].ToString();
        return build;
    }
    public string returnVersion()
    {
        string path = "Assets/TextFiles/Version.txt";
        string[] lines = System.IO.File.ReadAllLines (path);
        string vnum = lines[1].ToString();
        return vnum;
    }

}
