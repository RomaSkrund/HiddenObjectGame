using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HintMessageSend : MonoBehaviour
{
    public static Action<string> onHintSended;
}
