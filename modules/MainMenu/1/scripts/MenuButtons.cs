function NewGameButton::onClick(%this)
{
   Canvas.popDialog(MenuDialog);
   Canvas.pushDialog(OptionsDialog);
}

function QuitButton::onClick(%this)
{
   quit();
}

function StartGameButton::onClick(%this)
{
   // Load up the group that runs the game
   //  here instead of this placeholder
   //  group.
   ModuleDatabase.loadGroup("TDGame");
   Canvas.popDialog(OptionsDialog);
}

function MainMenuButton::onClick(%this)
{
   Canvas.popDialog(OptionsDialog);
   Canvas.pushDialog(MenuDialog);
}