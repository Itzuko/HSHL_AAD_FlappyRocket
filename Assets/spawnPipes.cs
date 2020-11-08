using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPipes : MonoBehaviour
{
    public GameObject pipes;
    private float variance;
    public float timeBetweenSpawn;
    public float elaspedTimer;

    // Start is called before the first frame update
    void Start()
    {
        elaspedTimer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        elaspedTimer += Time.deltaTime;

        if(elaspedTimer > timeBetweenSpawn)
        {
            spawnPipesFunction();
            elaspedTimer = 0.0f;
        }
    }

    public void spawnPipesFunction()
    {
        variance = Random.Range(-1.5f, 1.5f);

        Vector3 pos = new Vector3(this.transform.position.x, this.transform.position.y + variance, 1.0f);
        Quaternion q = this.transform.rotation;

        Instantiate(pipes, pos, q);
    }
}
