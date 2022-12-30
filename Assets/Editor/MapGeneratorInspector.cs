using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MapGenerator))]
public class MapGeneratorInspector : Editor {
    
    MapGenerator map;

    private void OnEnable() {
        map = (MapGenerator)target;
    }

    public override void OnInspectorGUI(){
        base.OnInspectorGUI();
        if (Application.isPlaying) {
            if(GUILayout.Button("Generate New Map")) {
                map.GenerateNewMap();
            }
            if(GUILayout.Button("Repair Map")) {
                map.TryRepair();
            }
        }
    }

}
