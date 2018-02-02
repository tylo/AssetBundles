using UnityEngine;
using UnityEditor;

class MyAllPostprocessor : AssetPostprocessor
{
    //static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    //{
    //    foreach (string str in importedAssets)
    //    {
    //        Debug.Log("Reimported Asset: " + str);
    //    }
    //    foreach (string str in deletedAssets)
    //    {
    //        Debug.Log("Deleted Asset: " + str);
    //    }

    //    for (int i = 0; i < movedAssets.Length; i++)
    //    {
    //        Debug.Log("Moved Asset: " + movedAssets[i] + " from: " + movedFromAssetPaths[i]);
    //    }
    //}

    void OnPostprocessModel(GameObject g)
    {
        //Debug.Log(g.GetInstanceID());
        //GameObject go = GameObject.Instantiate(g);

        //Object parentObject = PrefabUtility.FindPrefabRoot(go);

        //string assetPath = AssetDatabase.GetAssetPath(parentObject);
        Debug.Log("path: " + assetPath);
        AssetImporter.GetAtPath(assetPath).SetAssetBundleNameAndVariant("testBundle", "");
    }
}