using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan2 : ConteinerAllPanels
{
     public bool onOf;
    public int range;
    public ConteinerAllPanels cont;
    public GameObject closeThis;
  
   void Update()
   {
       range = cont.pan2;
       if(range ==1)
       {
           closeThis.SetActive(false);
       }
       else if(range == 0)
       {
           closeThis.SetActive(true);
       }
       if(closeThis.activeSelf == false)
       {
           onOf = false;
       }
       else
       {
           onOf = true;
       }
       if(onOf == false)
       {
           foreach(var panelItem in panelItems2)
           {
              panelItem.SetActive(true);
           }
         
       }
        if(onOf == true)
       {
           foreach(var panelItem in panelItems2)
           {
              panelItem.SetActive(false);
           }
       }
   }
}
