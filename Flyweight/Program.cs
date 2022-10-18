using Flyweight;

Console.Title = "Flyweight";

var characters = "aaabbbabbab";

var characterFactory = new CharacterFactory();

var characterObject = characterFactory.GetCharacter(characters[0]);
characterObject?.Draw("Arial", 12);

characterObject = characterFactory.GetCharacter(characters[1]);
characterObject?.Draw("Times New Roman", 14);

characterObject = characterFactory.GetCharacter(characters[2]);
characterObject?.Draw("Serif", 10);

characterObject = characterFactory.GetCharacter(characters[3]);
characterObject?.Draw("Sans-Serif", 15);

characterObject = characterFactory.GetCharacter(characters[4]);
characterObject?.Draw("Monaco", 11);

characterObject = characterFactory.GetCharacter(characters[5]);
characterObject?.Draw("Calibri", 18);

var paragraph = characterFactory.CreateParagraph(new List<ICharacter>() { characterObject }, 1);
paragraph.Draw("Helvetica", 20);


