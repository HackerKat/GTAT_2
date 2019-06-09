using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;

public class SphereFunction : GeneratorFunction
{
    public float getX(Vector2 uv)
    {
        float x = ((uv.x * 2) - 1) * PI;
        float y = ((uv.y * 2) - 1) * PI;
        return (Sin(x) * Sin(y));
    }

    public float getY(Vector2 uv)
    {
        float x = ((uv.x * 2) - 1) * PI;
        float y = ((uv.y * 2) - 1) * PI;
        return (Cos(x) * Sin(y));
    }

    public float getZ(Vector2 uv)
    {
        float x = ((uv.x * 2) - 1) * PI;
        float y = ((uv.y * 2) - 1) * PI;
        return (Cos(y));
    }
}
