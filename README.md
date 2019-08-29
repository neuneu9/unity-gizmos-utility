# gizmos-utility

## Screenshot
![screenshot](https://github.com/neuneu9/gizmos-utility/blob/images/screenshot.png)

## Example
```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosTestBehaviour : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.matrix = transform.localToWorldMatrix;

        Gizmos.color = Color.green;
        // 円(2D)
        GizmosUtility.DrawWireCircle(Vector3.zero, 2f);
        // 正三角形(2D)
        GizmosUtility.DrawWireRegularPolygon(3, new Vector3(4f, 0f, 0f), 2f);
        // 正四角形(2D)
        GizmosUtility.DrawWireRegularPolygon(4, new Vector3(8f, 0f, 0f), 2f);
        // 正五角形(2D)
        GizmosUtility.DrawWireRegularPolygon(5, new Vector3(12f, 0f, 0f), 2f);

        Gizmos.color = Color.red;
        // 円(3D)
        GizmosUtility.DrawWireCircle(new Vector3(16f, 0f, 0f), Quaternion.LookRotation(new Vector3(-1f, 1f, 0f)), 2f);
        // 正三角形(3D)
        GizmosUtility.DrawWireRegularPolygon(3, new Vector3(20f, 0f, 0f), Quaternion.LookRotation(new Vector3(-1f, 1f, 0f)), 2f);
        // 正四角形(3D)
        GizmosUtility.DrawWireRegularPolygon(4, new Vector3(24f, 0f, 0f), Quaternion.LookRotation(new Vector3(-1f, 1f, 0f)), 2f);
        // 正五角形(3D)
        GizmosUtility.DrawWireRegularPolygon(5, new Vector3(28f, 0f, 0f), Quaternion.LookRotation(new Vector3(-1f, 1f, 0f)), 2f);
    }
}
```
