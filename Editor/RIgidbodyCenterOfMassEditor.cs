using MegaTools.Utils;
using UnityEditor;
using UnityEngine;

namespace MegaTools.Editor.Utils
{
    [CustomEditor(typeof(RigidbodyCenterOfMass))]
    public class RigidbodyCenterOfMassEditor : UnityEditor.Editor
    {
        private void OnSceneGUI()
        {
            RigidbodyCenterOfMass rb = target as RigidbodyCenterOfMass;

            EditorGUI.BeginChangeCheck();

            Handles.color = new Color(1f, 0.18f, 0.24f, 0.5f);
            Handles.SphereHandleCap(0, rb.transform.TransformPoint(rb.CenterOfMass), Quaternion.identity, 0.25f,
                EventType.Repaint);

            Vector3 newTargetPosition =
                Handles.PositionHandle(rb.transform.TransformPoint(rb.CenterOfMass), Quaternion.identity);

            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(rb, "Change Center Of Mass Position");
                rb.CenterOfMass = newTargetPosition - rb.transform.position;
            }
        }
    }
}