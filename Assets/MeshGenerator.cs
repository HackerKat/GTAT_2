using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class MeshGenerator : MonoBehaviour
{
    [SerializeField]
    private int density;
    [SerializeField]
    private Vector3[] vertices;
    [SerializeField]
    private int[] indices;
    private Vector2[] uvs;

    private MeshFilter mf;

    private void Awake()
    {
        
    }

    private void Start()
    {
        GeneratorFunction function = new GridFunction();
        mf = GetComponent<MeshFilter>();
        Mesh mesh = new Mesh();
        mesh.name = "Procedural Mesh";
        mf.mesh = mesh;
        vertices = new Vector3[density * density];
        indices = new int[(density - 1) * (density - 1) * 3 * 2];
        uvs = new Vector2[vertices.Length];

        //generate vertices
        for (int index = 0, u = 0; u < density; u++) {
            for (int v = 0; v < density; index++, v++) {

                float u_ = (float)u / (density - 1);
                float v_ = (float)v / (density - 1);

                Vector2 uv = new Vector2(u_, v_);

                Vector3 vertex = new Vector3(function.getX(uv), function.getY(uv), function.getZ(uv));

                vertices[index] = vertex;
                uvs[index] = uv;

            }
        }

        //geenerate indices (traingles)
        for (int i = 0, index = 0; i < density - 1; i++) {
            for (int j = 0; j < density - 1; j++) {

                indices[index] = i + j * density;
                indices[index + 1] = (i + 1) + j * density;
                indices[index + 2] = i + (j + 1) * density;

                indices[index + 3] = (i + 1) + j * density;
                indices[index + 4] = (i + 1) + (j + 1) * density;
                indices[index + 5] = i + (j + 1) * density;

                index = index + 6;
            }
        }

        mesh.vertices = vertices;
        mesh.triangles = indices;
        mesh.uv = uvs;

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
        mesh.RecalculateTangents();

    }

    private void OnDrawGizmos()
    {

        Gizmos.color = Color.black;
        if (vertices == null)
        {
            return;
        }
        for (int i = 0; i < vertices.Length; i++)
        {
            Gizmos.DrawSphere(vertices[i], 0.001f);
        }
    }

}
