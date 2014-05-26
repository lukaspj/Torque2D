function FillBattle::create(%this)
{
   // Load all behavior scripts.
   exec("./scripts/RandomFillBehavior.cs");  
   exec("./scripts/CenterPositionBehavior.cs"); 
   exec("./scripts/ClickableTilesBehavior.cs"); 
   exec("./scripts/ButtonBehavior.cs");
   exec("./scripts/StackBehavior.cs");
   exec("./scripts/GameGlobals.cs");
   
   Canvas.BackgroundColor = "black";   
   
   // Load the game
   %this.loadGame();
}

//-----------------------------------------------------------------------------

function FillBattle::destroy(%this)
{
}

function FillBattle::loadGame(%this)
{
   exec("./objects/guiprofiles.cs");
   %window = TamlRead("./objects/SceneWindow.taml");
   Canvas.setContent(%window);
   
   %scene = TamlRead("./objects/Scene.taml");
   %window.setScene(%scene);
   
   %board = TamlRead("./objects/TileBoard.taml");
   %scene.add(%board);
}