#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using System.Linq;

class PreBuildProcessor
{
    [MenuItem("Resources/AssetsBundles/Build Asset Bundles/Windows")]
    public static void BuildAssetBundles()
    {
        Build(BuildTarget.StandaloneWindows64, Application.dataPath + "/StreamingAssets/");
    }

	public static void Build(BuildTarget target, string path) {
        //TestVersion();

        //EditorCoroutines.EditorCoroutines.StartCoroutine(DownloadFile(@"teapot.fbx"), this);
        DownloadFile(@"teapot.fbx");

        AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);

        //Debug.Log("Build Asset Bundles to " + path);

        //BuildPipeline.BuildAssetBundles(path,
        //                                BuildAssetBundleOptions.None,
        //                                target);

        //string[] levels = new string[] { "Assets/main.unity" };

        //string buildPath = Application.dataPath.Substring(0, Application.dataPath.Length - 6) + "Builds/test.exe";

        //Debug.Log("Building player to... " + buildPath);

        //BuildPipeline.BuildPlayer(levels, buildPath, BuildTarget.StandaloneWindows64, BuildOptions.ShowBuiltPlayer);
    }

    static void DownloadFile(string file)
    {

        Debug.Log("Downloading..." + file);

        string saveLoc = Application.dataPath;
        string url = @"https://github.com/McNopper/GraphicsEngine/raw/master/GE_Binaries/teapot.fbx";

        WWW www = new WWW(url);
        
        while (!www.isDone) {  }

        if (!string.IsNullOrEmpty(www.error))
            Debug.Log(www.error);

        string newPath = saveLoc + "\\" + file;

        Debug.Log("Saving a " + www.bytes.Length + " bytes file..." + newPath);

        File.WriteAllBytes(newPath, www.bytes);

        Debug.Log("Download finished.");
    }
}
#endif