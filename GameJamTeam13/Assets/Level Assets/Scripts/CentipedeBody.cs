using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentipedeBody : MonoBehaviour
{
    public List<CentipedeBodySection> sections = new List<CentipedeBodySection>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sections[0].UpdateSection();
    }
}

