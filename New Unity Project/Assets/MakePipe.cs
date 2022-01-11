using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Pipe;
    float timer = 0;
    public float timeDiff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>timeDiff)
        {
          GameObject newpipe = Instantiate(Pipe);
          newpipe.transform.position = new Vector3(6,Random.Range(-1.7f,4.3f),0);
          timer=0;
          Destroy(newpipe,10.0f);
        }
        
    }
}
