using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Fspel : MonoBehaviour
{
    public int playerHP;
    public int monsterHP;
    public int missMonster;
    int mana = 200; 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("-----------------");
            monsterHP -= 90;
            print(string.Format("Your HP:  {0} ",(playerHP)));
            playerHP -= Random.Range(100, 301);
            print(string.Format("Monster A  {0}", (monsterHP)));
            missMonster = Random.Range(1, 7);
            {
                if (missMonster == 1)
                print("The Monster Miss"); 
            }
            {
                if (missMonster >= 2)
                    monsterHP -= 1689;
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            playerHP += 1000;
            print(string.Format("You Have Been heald (+1000HP): {0}", playerHP));
            playerHP -= Random.Range(100, 301);
            
        }
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            mana -= 20;
            monsterHP -= 50;
            print(string.Format("FIRE BALL!!!!  {0}", mana));
            print(monsterHP);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            print("---------------------");
            print(string.Format("Your HP {0}", playerHP));
            print(string.Format("Monster HP {0}", monsterHP));
            print(string.Format("Your mana {0}", mana));
        }
    }
}
