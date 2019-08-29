using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Gizmosのユーティリティ
/// </summary>
public static class GizmosUtility
{
    private static int _circleVertexCount = 64;

    /// <summary>
    /// 円を描く(2D)
    /// </summary>
    /// <param name="center">中心位置</param>
    /// <param name="radius">半径</param>
    public static void DrawWireCircle(Vector3 center, float radius)
    {
        DrawWireRegularPolygon(_circleVertexCount, center, Quaternion.identity, radius);
    }

    /// <summary>
    /// 正多角形を描く(2D)
    /// </summary>
    /// <param name="vertexCount">角の数</param>
    /// <param name="center">中心位置</param>
    /// <param name="radius">半径</param>
    public static void DrawWireRegularPolygon(int vertexCount, Vector3 center, float radius)
    {
        DrawWireRegularPolygon(vertexCount, center, Quaternion.identity, radius);
    }

    /// <summary>
    /// 円を描く(3D)
    /// </summary>
    /// <param name="center">中心位置</param>
    /// <param name="rotation">回転</param>
    /// <param name="radius">半径</param>
    public static void DrawWireCircle(Vector3 center, Quaternion rotation, float radius)
    {
        DrawWireRegularPolygon(_circleVertexCount, center, rotation, radius);
    }

    /// <summary>
    /// 正多角形を描く(3D)
    /// </summary>
    /// <param name="vertexCount">角の数</param>
    /// <param name="center">中心位置</param>
    /// <param name="rotation">回転</param>
    /// <param name="radius">半径</param>
    public static void DrawWireRegularPolygon(int vertexCount, Vector3 center, Quaternion rotation, float radius)
    {
        if (vertexCount < 3)
        {
            return;
        }

        Vector3 previousPosition = Vector3.zero;

        // 線を引く1ステップの角度
        float step = 2f * Mathf.PI / vertexCount;
        // 線を引く開始角度(偶数なら半ステップずらす)
        float offset = Mathf.PI * 0.5f + ((vertexCount % 2 == 0) ? step * 0.5f : 0f);

        for (int i = 0; i <= vertexCount; i++)
        {
            float theta = step * i + offset;

            float x = radius * Mathf.Cos(theta);
            float y = radius * Mathf.Sin(theta);

            Vector3 nextPosition = center + rotation * new Vector3(x, y, 0f);

            if (i == 0)
            {
                previousPosition = nextPosition;
            }
            else
            {
                Gizmos.DrawLine(previousPosition, nextPosition);
            }

            previousPosition = nextPosition;
        }
    }
}
