using Text;
using Text.Decorator;


//On instencie nos Objets concrets

Title title = new Title();
Chapters chapters = new Chapters();
Paragraphe paragraphe = new Paragraphe();

//On passe le titre en gras

Bold boldTitle = new Bold(title);
boldTitle.DisplayText();
boldTitle.ChangeObject();
boldTitle.DisplayMarkedText();
boldTitle.DisplayState();

//On passe le titre en Italic

Italic italicTitle = new Italic(boldTitle);
italicTitle.ChangeObject();
italicTitle.DisplayMarkedText();
italicTitle.DisplayState();

//On traite le chapitre
Emphasize emphasizedChapter = new Emphasize(chapters);
emphasizedChapter.DisplayState();
emphasizedChapter.ChangeObject();
emphasizedChapter.DisplayState();
emphasizedChapter.DisplayMarkedText();

//Le paragraphe
paragraphe.DisplayState();
