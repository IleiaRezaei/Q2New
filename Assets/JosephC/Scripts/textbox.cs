using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textbox : MonoBehaviour
{
    
    int curtext = 0;
    private GameObject texobj;
    bool end;
    private Animator anim;
    private GameObject ico;
    private bool dialogue;
    private NPC nonpc;
    private void Start()
    {
        texobj = transform.GetChild(0).gameObject;
        anim = GetComponent<Animator>();
        ico = transform.GetChild(1).gameObject;
    }
    public void DoText(string[] text, Sprite[] pic,NPC n)
    {
        if (end == false)
        {
            anim.Play("TextboxOpen");
            dialogue = true;
            nonpc = n;
            DiaImpJsonClass texy = new DiaImpJsonClass();
            texy = JsonUtility.FromJson<DiaImpJsonClass>(text[curtext]);
            print(texy);
            string line = texy.Text;
            int icon = texy.Icon;
            



            print((icon, line));
            ico.GetComponent<Image>().sprite = pic[icon];
            texobj.GetComponent<Text>().text = line;

            if (curtext >= text.Length -1 )
            {
                end = true;

            }
            else
            {
                
                curtext += 1;
                
            }
            print((curtext, text.Length -1));
        }
        else
        {
            
            end = false;
            curtext = 0;
            anim.Play("TextboxClose");
            dialogue = false;
        }
    }
}
