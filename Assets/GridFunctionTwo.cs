using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;

public class GridFunctionTwo : GeneratorFunction
{
    public float getMaxU()
    {
        return 10;
    }

    public float getMaxV()
    {
        return 10;
    }

    public float getMinU()
    {
        return -10;
    }

    public float getMinV()
    {
        return -10;
    }

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
        return (Cos(Sqrt(Pow(uv.x, 2) + Pow (uv.y, 2))));
    }


}