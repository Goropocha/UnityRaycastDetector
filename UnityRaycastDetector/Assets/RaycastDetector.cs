using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

/// <summary>
/// Simple raycast detector
/// </summary>
public class RaycastDetector : Graphic {

  /// <summary>
  /// A utility class that can aid in the generation of meshes for the UI.
  /// </summary>
  /// <param name="vh">VertexHelper</param>
  protected override void OnPopulateMesh(VertexHelper vh) {
    // Clear all vertices from the stream.
    vh.Clear();
  }

#if UNITY_EDITOR
  [CustomEditor(typeof(RaycastDetector))]
  public class GraphicCastEditor : Editor {
    // Nothing show to Inspector
    public override void OnInspectorGUI() {}
  }
#endif
}
