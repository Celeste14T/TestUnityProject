using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections;

public class ButtonSelect : MonoBehaviour
{
    public string key;
    
    public void Update(){
        if (Input.GetKeyDown (key))
        {
            EventSystem.current.SetSelectedGameObject(
            this.gameObject);
        }

    }
    
}

