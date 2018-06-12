using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Names {

    public static List<string> NameList = new List<string>() {

            "Dickson",
            "Mcgrath",
            "Meyers",
            "King",
            "Wilcox",
            "Phillips",
            "Thornton",
            "Frost",
            "Skinner",
            "Meadows",
            "Vazquez",
            "Espinoza",
            "Frazier",
            "Bowman",
            "Horton",
            "Freeman",
            "Dodson",
            "Harper",
            "Duncan",
            "Ho"

    };

    public static string GetRandomName()
    {
        int i = Random.Range(0, 20);
        return NameList[i];
    }
}
