using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Collection : ScriptableObject
{

    public List<FloatData> CollectionList; 
    
    public void Collect(FloatData obj)
    {
        CollectionList.Add(obj);
    }

    public void CollectionInfo()
    {
        foreach (var obj in CollectionList)
        {
            Debug.Log(obj);
        }
    }

    public void SkillInfo()
    {
        foreach (var obj in CollectionList)
        {
            if (obj.name == "Burrow"){
                Debug.Log("Look for Places to Burrow!");
        }
    }
}
 
    public void SkillSlots()
    {
        for ( int i = 0; i < CollectionList.Count; i++)
        {
            
            if(CollectionList[i].name == "Skill")
           {
                Debug.Log(CollectionList[i]);
           }
         }
     }
}
