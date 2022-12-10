using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MazeGenerator))]
public class EditorGenerateButton : Editor
{
    public override void OnInspectorGUI()
    {
        MazeGenerator generator = (MazeGenerator)target;
        if (DrawDefaultInspector() && generator.autoUpdate)
        {
            generator.GenerateMaze(generator.mazeSize);
        };
        if (GUILayout.Button("Generate"))
        {
            generator.GenerateMaze(generator.mazeSize);
        }
    }
}
