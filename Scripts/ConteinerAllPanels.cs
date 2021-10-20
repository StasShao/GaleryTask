using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConteinerAllPanels : MonoBehaviour, Interf
{
 public GameObject[] close;
 public GameObject[] panels;
 public GameObject[] panelItems1;
 public GameObject[] panelItems2;
 public GameObject[] panelItems3;
 RectTransform rect;

 public int pan1;
 public int pan2;
 public int pan3;
  void Awake()
  {
      if(PlayerPrefs.HasKey("Save1"))
      {
        pan1 = PlayerPrefs.GetInt("Save1");
      }
      
      if(PlayerPrefs.HasKey("Save1"))
      {
         pan2 = PlayerPrefs.GetInt("Save2");
      }
      
      if(PlayerPrefs.HasKey("Save1"))
      {
        pan3 = PlayerPrefs.GetInt("Save3");
      }
     rect = GetComponent<RectTransform>();
     
     
  }
 public void Activating()
   {
       if(close[0].activeSelf == true)
       {
         close[0].SetActive(false);
         pan1 = 0;
       }
       else
       {
           close[0].SetActive(true);
           pan1 = 1;
       }

   }
   public void Activating2()
   {
     if(close[1].activeSelf == true)
       {
         close[1].SetActive(false);
         pan2 = 0;
       }
       else
       {
           close[1].SetActive(true);
           pan2 = 1;
       }
   }
   public void Activating3()
   {
    if(close[2].activeSelf == true)
       {
         close[2].SetActive(false);
         pan3 = 0;
       }
       else
       {
           close[2].SetActive(true);
           pan3 = 1;
       }
   }
   public void Saving()
   {
       if(close[0].activeSelf == true)
       {
           
         PlayerPrefs.SetInt("Save1", pan1 = 0);
       }
       else
       {
            
         PlayerPrefs.SetInt("Save1", pan1 = 1);  
       }
        if(close[1].activeSelf == true)
       {
           
         PlayerPrefs.SetInt("Save2", pan2 = 0);
       }
       else
       {
            
         PlayerPrefs.SetInt("Save2", pan2 = 1); 
       }
        if(close[2].activeSelf == true)
       {
           
         PlayerPrefs.SetInt("Save3", pan3 = 0);
       }
       else
       {
            
         PlayerPrefs.SetInt("Save3", pan3 = 1);   
       }
       
       
       
   }
   public void Loading()
   {
       if(PlayerPrefs.HasKey("Save1"))
       {
         pan1 = PlayerPrefs.GetInt("Save1");
       }
       
   }
}
