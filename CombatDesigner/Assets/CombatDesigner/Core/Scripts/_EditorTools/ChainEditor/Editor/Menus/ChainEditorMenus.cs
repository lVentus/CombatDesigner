﻿
#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace CombatDesigner.EditorTool
{
    /// <summary>
    public static class ChainEditorMenus
    {
        [MenuItem("CombatDesigner/Chain Editor")]
        public static void InitNodeEditor()
        {
            ChainEditorWindow.Open();
        }
    }
}