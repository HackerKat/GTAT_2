using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridFunction : GeneratorFunction
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

        return 0;
    }

    public float getMaxU()
    {
        return 1;
    }

    public float getMaxV()
    {
        return 1;
    }

    public float getMinU()
    {
        return 0;
    }

    public float getMinV()
    {
        return 0;
    }
}
