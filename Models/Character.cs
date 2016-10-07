using System.Collections.Generic;

namespace CharacterSheetApp.Models
{
    public class Character
    {
        public string Name;

        //public object Character { get; internal set; }

        public static void Create(string CharacterName)
        {
            var character = new Character();
            character.Name = CharacterName;
            //if (GlobalVariables.Characters == null)
                //GlobalVariables.Characters = new List<Character>();
            GlobalVariables.Characters.Add(character);
        }

        public static List<Character> GetAll()
        {
            //if (GlobalVariables.Characters == null)
                //GlobalVariables.Characters = new List<Character>();
            return GlobalVariables.Characters;
        }
    }
}