using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsSwitcher : MonoBehaviour
{
    public KeyCode switchKey;
    private Weapon[] weapons;
    private int index = 0;
    void Start()
    {
        weapons = GetComponentsInChildren<Weapon>();
        weapons[index].Switch(true);
        index++;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeWeapon();
    }
    void ChangeWeapon(){
        if(Input.GetKeyDown(switchKey)){
            
            for(int i = 0; i < weapons.Length; i++){
                weapons[i].Switch(false);
            }
            
            weapons[index].Switch(true);
            index++;

            if(index == weapons.Length){
                index = 0;
            }
        }
    }
}

