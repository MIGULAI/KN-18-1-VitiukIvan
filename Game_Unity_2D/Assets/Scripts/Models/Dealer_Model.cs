using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dealer_Model : MonoBehaviour
{
    private static Dealer_Model Dealer_model = new Dealer_Model();

    private Dealer_Model()
    {

    }

    public static Dealer_Model GetInstance()
    {
        return Dealer_model;
    }

}
