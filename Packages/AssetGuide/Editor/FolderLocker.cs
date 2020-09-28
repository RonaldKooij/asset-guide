using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.AssetImporters;

public class PermissionChecker : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {

        /*
        string fileContent = File.ReadAllText(ctx.assetPath);
        var booleanObj = ObjectFactory.CreateInstance<BooleanClass>();
        if (!bool.TryParse(fileContent, out booleanObj.boolean))
        {
            booleanObj.boolean = false;
        }
        ctx.AddObjectToAsset("main", booleanObj);
        ctx.SetMainObject(booleanObj);
        Debug.Log("Imported Boolean value: " + booleanObj.boolean);
        */

        
    }


    /*
    PermissionChecker : UnityEditor.AssetModificationProcessor
        private static AssetMoveResult OnWillMoveAsset(string sourcePath, string destinationPath)
        {
            Debug.Log("Source path: " + sourcePath + ". Destination path: " + destinationPath + ".");
            AssetMoveResult assetMoveResult = AssetMoveResult.DidNotMove;

            // Perform operations on the asset and set the value of 'assetMoveResult' accordingly.

            return assetMoveResult;
        }
    */

    /*
    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        foreach (string str in importedAssets)
        {
            Debug.Log("Reimported Asset: " + str);
        }
        foreach (string str in deletedAssets)
        {
            Debug.Log("Deleted Asset: " + str);
        }

        for (int i = 0; i < movedAssets.Length; i++)
        {
            Debug.Log("Moved Asset: " + movedAssets[i] + " from: " + movedFromAssetPaths[i]);
        }
    }*/
}
