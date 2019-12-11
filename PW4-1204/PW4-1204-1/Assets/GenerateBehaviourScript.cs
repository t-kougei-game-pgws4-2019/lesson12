using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBehaviourScript : MonoBehaviour
{
    GameObject prefab;
    public int INSTANCE_NUM = 1000;
    int last_instance_num = 1000;
    // Start is called before the first frame update

    void generate()
    {
        prefab = (GameObject)Resources.Load("Grass");
        for (int i = 0; i < INSTANCE_NUM; i++)
        {
            var inst = Instantiate(prefab);
            inst.transform.parent = gameObject.transform;

            inst.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0.7f, Random.Range(-10.0f, 10.0f));

            Instantiate(prefab, inst.transform.position, Quaternion.identity);
            //float y = Random.Range(0.3f, 1.0f);
            //inst.transform.localScale = new Vector3(0.1f, y, 0.1f);
        }
    }
    void Start()
    {
        generate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
