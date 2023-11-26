using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A05 : MonoBehaviour
{
    //Assignment.04.1
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    //Assighnment.04.2
    public string carMaker;


    public TextMeshProUGUI UITexts;
    public TextMeshProUGUI FuelConsumeText;


    public class Fuel
    {
        public int fuelLevel;


        public Fuel(int amount)
        {
            fuelLevel = amount;

        }

    }

    public Fuel carFuel = new Fuel(100);


    public void Start()
    {
        /* A.04.1
        print("The lacer model is " + carModel + ". It has a " + engineType + " engine.");
        */
        //print("The lacer model is " + carModel + ". It is made by " + carMaker + ". It has a " + engineType + " engine.");

        //UITexts = new TextMeshProUGUI();

        UITexts.text += "The lacer model is " + carModel + ". It is made by " + carMaker + ". It has a " + engineType + " engine.";
        //Debug.Log(UITexts.text);

        CheckWeight();
        if (yearMade <= 2009)
        {
            //print("The car was introduced in " + yearMade + ".");
            UITexts.text += "The car was introduced in " + yearMade + ".";

            int carAge = CalculateAge(yearMade);

            //print("That makes it " + carAge + "years old.");
            UITexts.text += "That makes it " + carAge + "years old.";
        }
        else
        {
            //print("The car was introduced in the 2010's.");
            UITexts.text += "The car was introduced in the 2010's.";
            //print("The car's maximum acceleration is " + maxAcceleration + "m/s2.");
            UITexts.text += "The car's maximum acceleration is " + maxAcceleration + "m/s2.";
        }

        //print(CheckCharacteristics());
        UITexts.text += CheckCharacteristics();

    }

    //A.04.2
    //public void Update()
    public void OnClick()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //if(Input.GetMouseButton(0))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }


    }

    public void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;

    }

    public void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {

            case 70:
                //print("fuel level is nearing two-thirds.");
                FuelConsumeText.text = "fuel level is nearing two-thirds.";
                break;

            case 50:
                //print("fuel level is at half amount.");
                FuelConsumeText.text = "fuel level is at half amount.";
                break;

            case 10:
                //print("Warning! Fuel level is critically low.");
                FuelConsumeText.text = "Warning! Fuel level is critically low.";
                break;

            default:
                //print("There is nothing to report.");
                FuelConsumeText.text = "There is nothing to report.";
                break;

        }
    }

    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            //print("The " + carModel + "weighs less than 1500kg.");
            UITexts.text = "The " + carModel + "weighs less than 1500kg.";
        }
        else
        {
            //print("The " + carModel + "weighs over 1500kg.");
            UITexts.text = "The " + carModel + "weighs over 1500kg.";
        }
    }

    int CalculateAge(int yearMade)
    {
        return 2023 - yearMade;
    }

    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            return "The car type is a sedan.";
        }

        else if (hasFrontEngine)
        {
            return "The car isn't a sedan, but has a front engine.";
        }

        else
        {
            return "The car is neither a sedan nor dose it have a front engine.";
        }
    }
}
