using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public Dictionary<string, string[]> dialogue = new Dictionary<string, string[]>();

    void Start()
    {
        //NPC
        dialogue.Add("CharacterA", new string[] {
            "Hi there!",
            "I'm an NPC! This conversation is called 'npcA'...",
            "If you go and find me 80 coins, my dialogue will move on to 'npcB'!",
            "Feel free to edit my dialogue in the 'Dialogue.cs' file!",
            "To keep it simple, you can also ask me one, and only one, question...",
            "...Like you just did! And I'll just move on to the next sentence.",
            "I'll answer that question, but it won't change much about the game!",
            "You can always tweak the 'DialogueBox.cs' script to add more functionality!"
        });

        dialogue.Add("CharacterB", new string[] {
            "Wow, Are you a Wanderer!",
            "I'm Pint",
            "The owner of this here shop",
            "We have a collection of different Assortments that can aid you in your quests",
            "Feel free to look around!"
        });

        dialogue.Add("CharacterC", new string[] {
            "Oh, thanks for sparing the moment",
            "A great calamity has befollen our land, could you maybe help us?",
            "you look cabable enough, i guess!",
            "I think i have some coins here, for your reward that is!",
            "Not too fast, you have to complete the quest first",
            "...Trying to cheat me"
        });
    }
}
