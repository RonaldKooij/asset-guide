using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;

[CustomEditor(typeof(DefaultAsset))]
public class FolderEditor : Editor
{
    private string _path;
    private AssetImporter _importer;
    private FolderInfo _info;

    protected override void OnHeaderGUI()
    {
        if (ValidateTarget())
        {
            FolderGUI();
        }
        else
        {
            base.OnHeaderGUI();
        }
    }

    //Called when a folder is selected, get our info here
    private void OnEnable()
    {
        if (!ValidateTarget())
            return;

        try
        {
            _info = JsonUtility.FromJson<FolderInfo>(_importer.userData);
        }
        catch (NullReferenceException)
        {
            //Debug.Log("Userdata either doesnt exist, or is corrupted");
        }
    }

    //Called when a folder is deselected, save our info here
    private void OnDisable()
    {
        if (!ValidateTarget())
            return;

        _importer.userData = JsonUtility.ToJson(_info);
    }

    //Visualise the info here
    private void FolderGUI()
    {
        _info.locked = GUILayout.Toggle(_info.locked, "Locked");
        _info.description = GUILayout.TextArea(_info.description);

        if (GUILayout.Button("scream"))
        {
            Debug.Log(_info.description);
        }
    }

    [Serializable]
    private struct FolderInfo
    {
        public string description;
        public bool locked;
    }

    /// <summary>
    /// Check if the target is viable for the special folder stuff,
    /// So make sure it is a folder, and not in the packages area
    /// </summary>
    /// <returns></returns>
    private bool ValidateTarget()
    {
        _path = AssetDatabase.GetAssetPath(target);
        _importer = AssetImporter.GetAtPath(_path);

        if (!Directory.Exists(_path) || _path.StartsWith("Packages") || _importer == null)
            return false;
        else
            return true;
    }
}