using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condition : MonoBehaviour
{

    public bool ifbool;
    public int value = 6;
    public int uservalue;
    public int dice;
    public int dice2;
    int start;
    public int dwagon;
    public int player = 100;
    public int damage;
    public int dwagonDamage;
    public int dragonChance;
    public int dubbelt;
    public int max;
    public int min;
    public int crit;
    public int värde;
    public string death;

    public string svar;
    public int number = 50;
    public int record;
    public int score;
    public int highscore;


    // Use this for initialization
    void Start()
    {
        highscore = 0;
        number = 50;
        record = 50;
        värde = 50;
        max = Random.Range(10, 26);
        min = Random.Range(1, 5);
        dice = 10;
        dwagon = Random.Range(100, 151);
        dubbelt = Random.Range(1, 11);

        if (dubbelt == 1)
        {
            print("It's dubble!!!");
            dwagon *= 2;
        }

        if (ifbool == true)
        {
            print("ja");
        }
        else
        {
            print("nej");
            print("det");
            print("finns");
            print("ass");
        }

        //!= inte lika med
        // > större än
        // == lika med
        // < mindre än
        // >= större än eller lika med 
        // && och
        // || eller 
        //Random.Range(x, y) 
        //=+ utskrivning


        if (value >= 5)
        {
            if (ifbool == true)

                print("Idon'tknow");

        }
        else if (value == 6)
        {
            print("200 G");
        }

        else if (value == 4)
        {
            print("die die die");

        }
        else
        {
            print("too bad");

        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {


            print("lol");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            uservalue += 2;
            print(uservalue);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            uservalue /= 2;
            print(uservalue);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(uservalue);
        }


        if (Input.GetKeyDown(KeyCode.R))
        {

            dice += Random.Range(0, 6);
            dice -= Random.Range(0, 6);

            print(dice);

            if (dice >= (20))
            {
                print("YOU WIN");
            }

            else if (dice <= (0))
            {
                print("LOSE");
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            dragonChance = (Random.Range(1, 3));
            damage -= (Random.Range(5, 25));
            if (dragonChance == 2)
            {
                player -= Random.Range(10, 21);
                print("HIT");

            }
            if (dragonChance == 1)
            {
                print("THE DRAGON IS DRUNK");
            }
            dwagon -= Random.Range(5, 26);
            if (dwagon <= 0)
            {
                print("Dragon slain");
            }

            if (player <= 0)
            {
                print("YOU DIED");
            }
            print(string.Format("player health {0}", player));
            print(string.Format("dragon's health {0}", dwagon));

            crit = Random.Range(1, 21);
            if (crit == 1)
            {
                dwagon -= 9999;
                print("IT's A CRIT!!");


            }

        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            print("you guess higher");
            number = Random.Range(0, 101);
            print(number);

            if (number >= 50)
            {
                print("haa. you made it");
                score += 1;
                print(string.Format("score  {0}", score));
                highscore += 1;
            }
            if (number <= 50)
            {
                print("you lose");
                score -= score;
            }
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            print("you guess lower");
            number = Random.Range(0, 101);
            print(number);

            if (number <= 50)
            {
                print("haa. you made it");
                score += 1;
                print(string.Format("score  {0}", score));
                highscore += 1;
            }
            if (number >= 50)
            {
                print("you lose");
                score -= score;
            }

        }

    }
}
