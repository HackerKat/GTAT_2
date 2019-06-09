using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GeneratorFunction
{

    float getX(Vector2 uv);

    float getY(Vector2 uv);

    float getZ(Vector2 uv);

    float getMinU();

    float getMaxU();

    float getMaxV();

    float getMinV();

}
