using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BronzeUnit : Unit
{
    public override void Initialize(string filename, int count)
    {
        data = CSVReader.Read(filename);

        name = (string)data[count]["name"];
        health = System.Convert.ToInt32(data[count]["health"]);
        attack = System.Convert.ToInt32(data[count]["attack"]);
    }

    protected override void Movement()
    {
        Debug.Log("�̵�");
    }  

}
