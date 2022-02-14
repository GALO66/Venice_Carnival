using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factorys : MonoBehaviour
{
    public GameObject Prefab;
    public double MakeRate = 2.0f;
    private float _lastMake = 0;
    private int _madeCount = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _lastMake += Time.deltaTime;
        if (_lastMake > MakeRate)
        {
            _lastMake = 0;
            GameObject go = Instantiate(Prefab, this.transform.position, Quaternion.identity);
            Mobility mb = go.GetComponent<Mobility>();
        }
    }
}
