function GameGUI::create( %this )
{
   // Exec scripts
   exec("./gui/guiprofiles.cs");
   exec("./scripts/TowerButtons.cs");
   exec("./scripts/WorldEditorButtons.cs");
   
   
   GameWindow.add( TamlRead("./gui/TowerSelection.gui.taml") );
   GameWindow.add( TamlRead("./gui/WorldEditor.gui.taml") );
}

function GameGUI::destroy( %this )
{
}