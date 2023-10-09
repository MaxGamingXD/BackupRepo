using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnDice : MonoBehaviour
{
    public int DiceAmount;
    public int DiceOneType;
    public int DiceTwoType;
    public int DiceThreeType;
    public int DiceFourType;
    //0 = is pure, 1 = slashing, 2 is blunt 3 is peericeing
    public int[] DiceOneRange;
    public int[] DiceTwoRange;
    public int[] DiceThreeRange;
    public int[] DiceFourRange;

    public int ReturnDiceOneRange(int WhatToReturn) { return DiceOneRange[WhatToReturn];}
    public int ReturnDiceTwoRange(int WhatToReturn) { return DiceTwoRange[WhatToReturn]; }
    public int ReturnDiceThreeRange(int WhatToReturn) { return DiceThreeRange[WhatToReturn]; }
    public int ReturnDiceFourRange(int WhatToReturn) { return DiceFourRange[WhatToReturn]; }
    public int ReturnDiceAmountRange() { return DiceAmount; }
    public int ReturnDiceOneRange() { return DiceOneType; }
    public int ReturnDiceTwoRange() { return DiceTwoType; }
    public int ReturnDiceThreeRange() { return DiceThreeType; }
    public int ReturnDiceFourRange() { return DiceFourType; }

    void Start()
    {

    }
    void Update()
    {

    }
}
