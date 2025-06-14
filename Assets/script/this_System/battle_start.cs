using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CharacterDB;

public class battle_start : menuScript
{
    [SerializeField] GameObject gm , backGround , battleMap;
    [SerializeField] CharacterDB.Character_table character_table;
    [SerializeField] breakScene breakScene ;
    private F_numberSetting f_NumberSetting;
    private List<parameters> battleMember;
    
    public override void select()
    {
       breakScene.StartCoroutine("BreakStart");
    }
    IEnumerator _battle()
    {
        f_NumberSetting = gm.GetComponent<F_numberSetting>();
        foreach (parameters _DB in character_table._characterDB)
        {
            battleMember.Add(_DB);
        }

        battleMap.SetActive(true);
        yield return null;
    }
}
