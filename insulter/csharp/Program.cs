﻿using System;
using System.Collections.Generic;

Main();

void Main() {
    Random randomizer = new Random();
    List<string> insults = new List<string> {"You look like what morning breath smells like.",
    "If you tried to give me cpr I would probably throw myself back under water",
    "I am not a fan of you",
    "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
    "I'd rather walk than be on the same plane as you",
    "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
    "Do you have to be so...like that?"};

    List<int> indexes = new List<int>();
    while (indexes.Count < 3) {
        int candidate = randomizer.Next(0, insults.Count - 1);
        if (!indexes.Contains(candidate)) {
            indexes.Add(candidate);
        }
    }

    for (int i = 0; i < indexes.Count; i++) {
        Console.WriteLine(insults[indexes[i]]);
    }
}