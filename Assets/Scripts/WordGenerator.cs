﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    //Array or random words; temporary
    private static string[] wordList = {   "sidewalk", "robin", "three", "protect", "periodic",
									"somber", "majestic", "jump", "pretty", "wound", "jazzy",
									"memory", "join", "crack", "grade", "boot", "cloudy", "sick",
									"mug", "hot", "tart", "dangerous", "mother", "rustic", "economic",
									"weird", "cut", "parallel", "wood", "encouraging", "interrupt",
									"guide", "long", "chief", "mom", "signal", "rely", "abortive",
									"hair", "representative", "earth", "grate", "proud", "feel",
									"hilarious", "addition", "silent", "play", "floor", "numerous",
									"friend", "pizzas", "building", "organic", "past", "mute", "unusual",
									"mellow", "analyse", "crate", "homely", "protest", "painstaking",
									"society", "head", "female", "eager", "heap", "dramatic", "present",
									"sin", "box", "pies", "awesome", "root", "available", "sleet", "wax",
									"boring", "smash", "anger", "tasty", "spare", "tray", "daffy", "scarce",
									"account", "spot", "thought", "distinct", "nimble", "practise", "cream",
									"ablaze", "thoughtless", "love", "verdict", "giant"    };

    //Generate a random word from the array
    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length); // Create random index
        string randomWord = wordList[randomIndex]; // Find word at random index

        return randomWord;
    }
}