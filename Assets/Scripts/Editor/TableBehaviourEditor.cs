using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TableBehaviour))]
public class NewBehaviourScript : Editor
{
    int value;
    int index;
    public override void OnInspectorGUI()
    {
        TableBehaviour tableBehaviour = target as TableBehaviour;
        EditorGUILayout.LabelField("Add", EditorStyles.boldLabel);
        value = EditorGUILayout.IntField("Value", value);

        if (GUILayout.Button("Add"))
        {
            tableBehaviour.AddToList(tableBehaviour.entryList.Count.ToString(), value);
        }

        EditorGUILayout.LabelField("Remove", EditorStyles.boldLabel);
        index = EditorGUILayout.IntField("Value", index);
        if (GUILayout.Button("Remove"))
        {
            tableBehaviour.RemoveFromList(index);
        }
        EditorGUI.BeginDisabledGroup(true);
        EditorGUILayout.LabelField("List", EditorStyles.boldLabel);
        for (int i = 0; i < tableBehaviour.entryList.Count; i++)
        {
            EditorGUILayout.FloatField(tableBehaviour.entryList[i].key, tableBehaviour.entryList[i].value);
        }
        EditorGUI.EndDisabledGroup();
    }
}
