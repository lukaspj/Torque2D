function MainMenu::create( %this )
{
   exec("./scripts/MenuButtons.cs");
   MainMenu.add( TamlRead("./gui/MenuDialog.gui.taml") );
   Canvas.pushDialog(MenuDialog);
   
   // Add the options dialog
   MainMenu.add( TamlRead("./gui/OptionsDialog.gui.taml") );
}

function MainMenu::destroy( %this )
{
}