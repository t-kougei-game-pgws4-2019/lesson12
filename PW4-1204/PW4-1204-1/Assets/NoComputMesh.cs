using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
    [RequireComponent(typeof(MeshFilter))]
public class NoComputMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var mesh = new Mesh();
        mesh.vertices = new Vector3[] {
            new Vector3 (0, 4f),
            new Vector3 (-0.5f, -1f,-0.5f),
            new Vector3 (-1f, -1f,0.5f),

            new Vector3 (0, 4f),
            new Vector3 (1f, -1f,0.5f),
            new Vector3 (-0.5f, -1f,-0.5f),

        };
        mesh.triangles = new int[] {
            0, 1, 2,3,4,5
        };
        mesh.RecalculateNormals();
        var filter = GetComponent<MeshFilter>();
        filter.sharedMesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
