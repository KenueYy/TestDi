#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace Editor {
    [InitializeOnLoad]
    public class HierarchyLabel : MonoBehaviour {
        static HierarchyLabel() {
            EditorApplication.hierarchyWindowItemOnGUI += HierarchyWindowItemOnGUI;
        }

        private static void HierarchyWindowItemOnGUI(int instanceID, Rect selectionRect) {
            var obj = EditorUtility.InstanceIDToObject(instanceID) as GameObject;

            if (obj == null) {
                return;
            }
            
            bool ProperName(string firstPartName) {
                return obj.name.StartsWith(firstPartName);
            }

            void ModifyObjectName(string firstPartName, Color color) {
                EditorGUI.DrawRect(selectionRect, color);
                EditorGUI.DropShadowLabel(selectionRect, obj.name.Remove(0, firstPartName.Length));
            }

            if (ProperName("!")) {
                ModifyObjectName("!", Color.red);
            }else if (ProperName("~")) {
                ModifyObjectName("~", Color.yellow);
            }else if (ProperName("-")) {
                ModifyObjectName("-", Color.green);
            } else if (ProperName("*")) {
                ModifyObjectName("*", Color.cyan);
            } else if (ProperName("&")) {
                ModifyObjectName("&", Color.magenta);
            }
        }

        
    }
}

#endif