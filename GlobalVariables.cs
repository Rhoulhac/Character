using System.Collections.Generic;
using CharacterSheetApp.Models;
using System;

namespace CharacterSheetApp
{
    public static class GlobalVariables
    {
        public static List<Character> Characters { get; set; }
            = new List<Character>();
    }
}