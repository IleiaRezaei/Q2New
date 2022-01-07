using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public string[] text;
    public Sprite[] icons;
    private ParticleSystem partic;


    private void Start()
    {
        partic = GetComponent<ParticleSystem>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public string[] InterAct()
    {
        return text;
    }
    public Sprite[] geticons()
    {
        return icons;
    }
    public void End()
    {
        partic.Stop();
    }
}
