using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;

public class SphereFunction : GeneratorFunction
{
    public float getX(Vector2 uv)
    {
        return (Sin(uv.x) * Sin(uv.y));
    }

    public float getY(Vector2 uv)
    {
        return (Cos(uv.x) * Sin(uv.y));
    }

    public float getZ(Vector2 uv)
    {
        return (Cos(uv.y));
    }
}
