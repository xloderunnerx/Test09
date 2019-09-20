using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    public static Vector3 GetMouseWorldCoordinates() => Camera.main.ScreenToWorldPoint(Input.mousePosition);
}
