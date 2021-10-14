using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string name;
    public GameObject weaponModel;

    public void Switch(bool state){
        if(state == true)
            weaponModel.SetActive(true);
        else
            weaponModel.SetActive(false);
    }
}
