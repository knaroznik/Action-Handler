using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class CreateActionHandler : EditorWindow
{
    string newActionName = "XD";

    [MenuItem("Component/ActionHandler/Open Window")]
    public static void ShowWindow()
    {
        GetWindow<CreateActionHandler>("Create Actionhandler");
    }

    private void OnGUI()
    {
        GUILayout.Label("Select folder and type name of new ActionHandler", EditorStyles.boldLabel);
        newActionName = EditorGUILayout.TextField("ActionName", newActionName);

        if (GUILayout.Button("Create"))
        {
            Create(newActionName);
        }
    }

    static void Create(string name)
    {

        string path = AssetDatabase.GetAssetPath(Selection.activeObject);
        if (path == "")
        {
            path = "Assets";
        }
        else if (Path.GetExtension(path) != "")
        {
            path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");
        }

        string fullPath = path + "/" + name + ".cs";

        Debug.Log("Creating Classfile: " + fullPath);
        if (File.Exists(fullPath) == false)
        {
            using (StreamWriter outfile =
                new StreamWriter(fullPath))
            {
                outfile.WriteLine("using UnityEngine;");
                outfile.WriteLine("using System.Collections;");
                outfile.WriteLine("");
                outfile.WriteLine("public class " + name + " : ActionHandlerBase {");
                outfile.WriteLine(" // Use Invoke to play your Action");
                outfile.WriteLine(" ");
                outfile.WriteLine(" ");
                outfile.WriteLine("}");
            }
        }
        AssetDatabase.Refresh();
    }
}
