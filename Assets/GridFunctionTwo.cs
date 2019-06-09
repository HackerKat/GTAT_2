using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;

public class GridFunctionTwo : GeneratorFunction
{
    public float getX(Vector2 uv)
    {
        return uv.x;
    }

    public float getY(Vector2 uv)
    {
        return uv.y;
    }

    public float getZ(Vector2 uv)
    {

        float x = ((uv.x * 2) - 1) * 10;
        float y = ((uv.y * 2) - 1) * 10;
        return (Cos(Sqrt(Pow(x, 2) + Pow(y, 2)))) * 0.1f;
    }
}
